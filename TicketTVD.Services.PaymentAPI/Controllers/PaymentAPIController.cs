using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using TicketTVD.Services.PaymentAPI.Models.Dto;
using Stripe;
using TicketTVD.MessageBus;
using TicketTVD.Services.PaymentAPI.Data;
using TicketTVD.Services.PaymentAPI.Models;
using TicketTVD.Services.PaymentAPI.Models.Enum;
using TicketTVD.Services.PaymentAPI.Services;
using TicketTVD.Services.PaymentAPI.Services.IServices;

namespace TicketTVD.Services.PaymentAPI.Controllers
{
    [Route("payment")]
    [ApiController]
    public class PaymentAPIController : ControllerBase
    {
        private readonly IMessageBus _messageBus;
        private readonly ITicketService _ticketService;
        private readonly IEventService _eventService;
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        protected ResponseDto _response;

        public PaymentAPIController(IMessageBus messageBus, ITicketService ticketService, IEventService eventService,
            ApplicationDbContext db,
            IMapper mapper, IConfiguration configuration)
        {
            _messageBus = messageBus;
            _ticketService = ticketService;
            _eventService = eventService;
            _db = db;
            _mapper = mapper;
            _configuration = configuration;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            try
            {
                var payments = _db.Payments.ToList();
                _response.Data = _mapper.Map<IEnumerable<PaymentDto>>(payments);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
            }

            return Ok(_response);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetPaymentByUserId([FromQuery] string? search, string userId)
        {
            try
            {
                var payments = _db.Payments.Where(p => p.UserId == userId).ToList();

                var events = _eventService.GetEventsByTickets(new EventsByTicketsDto
                {
                    Search = search,
                    EventIds = payments.Select(p => p.EventId)
                }).GetAwaiter().GetResult().ToList();

                var myTickets = payments.Join(events, p => p.EventId, e => e.Id, (p, e) => new
                {
                    Id = p.Id,
                    EventId = p.EventId,
                    UserId = p.UserId,
                    Quantity = p.Quantity,
                    TotalPrice = p.TotalPrice,
                    Discount = p.Discount,
                    CoverImage = e.CoverImage,
                    Name = e.Name,
                    Location = e.Location,
                    EventDate = e.EventDate,
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt
                }).DistinctBy(mt => mt.Id);

                _response.Data = myTickets;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
            }

            return Ok(_response);
        }

        [HttpGet]
        [Route("event/{eventId:int}")]
        public async Task<IActionResult> GetPaymentByEventId(int eventId)
        {
            try
            {
                var payments = _db.Payments.Where(p => p.EventId == eventId).ToList();

                _response.Data = _mapper.Map<IEnumerable<PaymentDto>>(payments);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
            }

            return Ok(_response);
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutDto checkoutDto)
        {
            try
            {
                PaymentDto paymentDto = _mapper.Map<PaymentDto>(checkoutDto);
                paymentDto.CreatedAt = DateTime.Now;
                paymentDto.UpdatedAt = DateTime.Now;
                paymentDto.Status = Status.PENDING;
                paymentDto.TotalPrice =
                    (decimal)checkoutDto.Tickets.Sum(t => (long)(t.Price) * (100 - checkoutDto.Discount) / 100);

                Payment paymentCreated = _db.Payments.Add(_mapper.Map<Payment>(paymentDto)).Entity;
                await _db.SaveChangesAsync();

                _response.Data = paymentCreated;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
            }

            return Ok(_response);
        }

        // [Authorize]
        [HttpPost("create-stripe-session")]
        public async Task<ResponseDto> CreateStripeSession([FromBody] StripeRequestDto stripeRequestDto)
        {
            try
            {
                var options = new SessionCreateOptions
                {
                    SuccessUrl = stripeRequestDto.ApprovedUrl,
                    CancelUrl = stripeRequestDto.CancelUrl,
                    LineItems = new List<SessionLineItemOptions>(),
                    Mode = "payment",
                };

                foreach (var item in stripeRequestDto.Tickets.ToList())
                {
                    var sessionItemLine = new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (long)(item.Price),
                            Currency = "vnd",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = $"{item.OwnerName} - {item.OwnerEmail} - {item.OwnerPhone}",
                            },
                        },
                        Quantity = 1
                    };

                    options.LineItems.Add(sessionItemLine);
                }

                var service = new SessionService();
                Session session = service.Create(options);
                stripeRequestDto.StripeSessionUrl = session.Url;

                Payment payment =
                    _db.Payments.First(u => u.Id == stripeRequestDto.PaymentId);
                payment.StripeSessionId = session.Id;

                _db.SaveChanges();

                await _ticketService.CreateTickets(payment.Id, new CreateTicketsDto
                {
                    Tickets = stripeRequestDto.Tickets
                });

                _response.Data = stripeRequestDto;
            }
            catch (Exception ex)
            {
                _response.Data = ex.Message.ToString();
                _response.IsSuccess = false;
            }

            return _response;
        }

        // [Authorize]
        [HttpPost("validate-stripe-session/{paymentId:int}")]
        public async Task<ResponseDto> ValidateStripeSession(int paymentId)
        {
            try
            {
                Payment payment = _db.Payments.First(u => u.Id == paymentId);

                var service = new SessionService();
                Session session = service.Get(payment.StripeSessionId);

                var paymentDto = new PaymentDto();

                if (payment.Status == Status.APPROVED)
                {
                    var tickets = await _ticketService.GetTicketsByPaymentId(paymentId);
                    paymentDto = _mapper.Map<PaymentDto>(payment);
                    paymentDto.Tickets = tickets;
                }
                else if (payment.TotalPrice == 0)
                {
                    payment.Status = Status.APPROVED;
                    payment.UpdatedAt = DateTime.Now;
                    var tickets = await _ticketService.ValidateTickets(paymentId, true);
                    paymentDto = _mapper.Map<PaymentDto>(payment);
                    paymentDto.Tickets = tickets;
                    _db.SaveChanges();
                }
                else
                {
                    var paymentIntentService = new PaymentIntentService();
                    PaymentIntent paymentIntent = paymentIntentService.Get(session.PaymentIntentId);

                    if (paymentIntent.Status == "succeeded")
                    {
                        // Then payment was successful
                        payment.PaymentIntentId = paymentIntent.Id;
                        payment.Status = Status.APPROVED;
                        _db.SaveChanges();
                        var tickets = await _ticketService.ValidateTickets(paymentId, true);
                        paymentDto = _mapper.Map<PaymentDto>(payment);
                        paymentDto.Tickets = tickets;

                        await _messageBus.PublishMessage(new ValidateStripeResponseDto
                            {
                                Quantity = paymentDto.Quantity,
                                TotalPrice = paymentDto.TotalPrice,
                                Discount = paymentDto.Discount,
                                CustomerName = paymentDto.CustomerName,
                                CustomerEmail = paymentDto.CustomerEmail,
                                CustomerPhone = paymentDto.CustomerPhone,
                                Tickets = paymentDto.Tickets,
                            },
                            _configuration.GetValue<string>("TopicAndQueueNames:EmailTicketQueue"));
                    }
                    else
                    {
                        payment.Status = Status.CANCELLED;
                        _ticketService.ValidateTickets(paymentId, false);
                        _response.IsSuccess = false;
                    }
                }


                _response.Data = new ValidateStripeResponseDto
                {
                    Id = paymentDto.Id,
                    Quantity = paymentDto.Quantity,
                    EventId = paymentDto.Tickets.First().EventId,
                    Status = paymentDto.Status,
                    Tickets = paymentDto.Tickets,
                    Discount = paymentDto.Discount,
                    CustomerEmail = paymentDto.CustomerEmail,
                    CustomerName = paymentDto.CustomerName,
                    CustomerPhone = paymentDto.CustomerPhone,
                    TotalPrice = paymentDto.TotalPrice,
                    UserId = paymentDto.UserId,
                    PaymentIntentId = paymentDto.PaymentIntentId,
                    StripeSessionId = paymentDto.StripeSessionId,
                    CreatedAt = paymentDto.CreatedAt,
                    UpdatedAt = paymentDto.UpdatedAt
                };

                if (payment.TotalPrice != 0)
                {
                    var paymentIntentService = new PaymentIntentService();
                    PaymentIntent paymentIntent = paymentIntentService.Get(session.PaymentIntentId);
                    var paymentMethodService = new PaymentMethodService();
                    PaymentMethod paymentMethod = paymentMethodService.Get(paymentIntent.PaymentMethodId);
                    (_response.Data as ValidateStripeResponseDto).PaymentMethod = new PaymentMethodDto
                    {
                        Card = paymentMethod.Card.Brand,
                        Last4 = paymentMethod.Card.Last4
                    };
                }
            }
            catch (Exception ex)
            {
                _response.Data = ex.Message.ToString();
                _response.IsSuccess = false;
            }

            return _response;
        }
    }
}