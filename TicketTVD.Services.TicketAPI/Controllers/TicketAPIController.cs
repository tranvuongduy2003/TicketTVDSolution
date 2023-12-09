using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketTVD.Services.TicketAPI.Models.Dto;
using TicketTVD.Services.TicketAPI.Services.IServices;

namespace TicketTVD.Services.TicketAPI.Controllers
{
    [Route("ticket")]
    [ApiController]
    public class TicketAPIController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        protected ResponseDto _response;

        public TicketAPIController(ITicketService ticketService)
        {
            _ticketService = ticketService;
            _response = new();
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                var ticketDtos = await _ticketService.GetTickets();

                _response.Data = ticketDtos;
                _response.Message = "Get tickets successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }

        [HttpGet]
        [Route("my-tickets/{userId}")]
        public async Task<IActionResult> GetTicketsByUserId(string userId)
        {
            try
            {
                var ticketDtos = await _ticketService.GetTickets();

                _response.Data = ticketDtos;
                _response.Message = "Get tickets successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            try
            {
                var ticketDto = await _ticketService.GetTicketById(id);

                if (ticketDto is null)
                {
                    _response.IsSuccess = false;
                    _response.Message = "Không tìm thấy thông tin vé!";
                    return NotFound(_response);
                }

                _response.Data = ticketDto;
                _response.Message = "Get the ticket successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpGet]
        [Route("get-by-payment/{paymentId:int}")]
        public async Task<IActionResult> GetTicketsByPaymentId(int paymentId)
        {
            try
            {
                var ticketDtos = await _ticketService.GetTicketsByPaymentId(paymentId);

                _response.Data = ticketDtos;
                _response.Message = "Get tickets successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPost]
        [Route("create-tickets/{paymentId:int}")]
        public async Task<IActionResult> CreateTickets(int paymentId, [FromBody] CreateTicketsDto createTicketsDto)
        {
            try
            {
                var ticketDtos = await _ticketService.CreateTickets(paymentId, createTicketsDto);

                _response.Data = ticketDtos;
                _response.Message = "Create new tickets successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
        
        [HttpPatch]
        [Route("validate-tickets/{paymentId:int}")]
        public async Task<IActionResult> ValidateTickets(int paymentId, [FromBody] bool isSuccess)
        {
            try
            {
                var ticketDtos = await _ticketService.ValidateTickets(paymentId, isSuccess);

                _response.Data = ticketDtos;
                _response.Message = "Validate tickets successfully!";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message.ToString();
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }

            return Ok(_response);
        }
    }
}