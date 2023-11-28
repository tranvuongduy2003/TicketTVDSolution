using AutoMapper;
using TicketTVD.Services.TicketAPI.Data;
using TicketTVD.Services.TicketAPI.Models;
using TicketTVD.Services.TicketAPI.Models.Dto;
using TicketTVD.Services.TicketAPI.Services.IServices;
using TicketTVD.Services.TicketAPI.Utility;

namespace TicketTVD.Services.TicketAPI.Services;

public class TicketService : ITicketService
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public TicketService(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TicketDto>> GetTickets()
    {
        try
        {
            var tickets = (from t in _db.Tickets
                join td in _db.TicketDetails on t.TicketDetailId equals td.Id
                select new TicketDto
                {
                    Id = t.Id,
                    OwnerName = t.OwnerName,
                    OwnerEmail = t.OwnerEmail,
                    OwnerPhone = t.OwnerPhone,
                    StartTime = td.StartTime,
                    CloseTime = td.CloseTime,
                    Price = td.Price,
                    EventId = td.EventId,
                    TicketCode = t.TicketCode
                }).ToList();

            // var ticketDtos = _mapper.Map<IEnumerable<TicketDto>>(tickets);

            return tickets;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<TicketDetailDto>> GetTicketDetails()
    {
        try
        {
            var ticketDetails = _db.TicketDetails.ToList();
            var ticketDetailDtos = _mapper.Map<IEnumerable<TicketDetailDto>>(ticketDetails);

            return ticketDetailDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<TicketDto?> GetTicketById(int ticketId)
    {
        try
        {
            var ticket = (from t in _db.Tickets
                join td in _db.TicketDetails on t.TicketDetailId equals td.Id
                select new TicketDto
                {
                    Id = t.Id,
                    OwnerName = t.OwnerName,
                    OwnerEmail = t.OwnerEmail,
                    OwnerPhone = t.OwnerPhone,
                    StartTime = td.StartTime,
                    CloseTime = td.CloseTime,
                    Price = td.Price,
                    EventId = td.EventId,
                    TicketCode = t.TicketCode
                }).FirstOrDefault(t => t.Id == ticketId);

            if (ticket is null)
            {
                return null;
            }

            // var ticketDto = _mapper.Map<TicketDto>(ticket);

            return ticket;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<TicketDto>> GetTicketsByPaymentId(int paymentId)
    {
        try
        {
            var tickets = (from t in _db.Tickets
                join td in _db.TicketDetails on t.TicketDetailId equals td.Id
                where t.PaymentId == paymentId
                select new TicketDto
                {
                    Id = t.Id,
                    OwnerName = t.OwnerName,
                    OwnerEmail = t.OwnerEmail,
                    OwnerPhone = t.OwnerPhone,
                    StartTime = td.StartTime,
                    CloseTime = td.CloseTime,
                    Price = td.Price,
                    EventId = td.EventId,
                    TicketCode = t.TicketCode
                }).ToList();

            // var ticketDtos = _mapper.Map<IEnumerable<TicketDto>>(tickets);

            return tickets;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<TicketDto>> CreateTickets(int paymentId, CreateTicketsDto createTicketsDto)
    {
        try
        {
            var tickets = _mapper.Map<IEnumerable<Ticket>>(createTicketsDto.Tickets);

            foreach (var ticket in tickets)
            {
                ticket.PaymentId = paymentId;
                var ticketDetail =
                    _db.TicketDetails.First(td => td.EventId == createTicketsDto.Tickets.First().EventId);
                ticket.TicketDetailId = ticketDetail.Id;
                ticket.IsPaid = false;
                ticket.CreatedAt = DateTime.Now;
                ticket.UpdatedAt = DateTime.Now;
            }
            
            _db.Tickets.AddRange(tickets);
            _db.SaveChanges();

            // var ticketDtos = _mapper.Map<IEnumerable<TicketDto>>(tickets);

            return _mapper.Map<IEnumerable<TicketDto>>(tickets);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<IEnumerable<TicketDto>> ValidateTickets(int paymentId, bool isSuccess)
    {
        try
        {
            var tickets = _db.Tickets.Where(t => t.PaymentId == paymentId).ToList();

            if (isSuccess)
            {
                foreach (var ticket in tickets)
                {
                    ticket.TicketCode =
                        TicketCodeGenerator.HashSHA512String(ticket.OwnerName, ticket.OwnerEmail, ticket.OwnerPhone);
                    ticket.IsPaid = true;
                    ticket.UpdatedAt = DateTime.Now;
                }

                var ticketDetail = _db.TicketDetails.First(td => td.Id == tickets.First().TicketDetailId);
                ticketDetail.Quantity -= tickets.Count();

                _db.SaveChanges();
                
                var ticketDtos = (from t in tickets
                    join td in _db.TicketDetails on t.TicketDetailId equals td.Id
                    where t.PaymentId == paymentId
                    select new TicketDto
                    {
                        Id = t.Id,
                        OwnerName = t.OwnerName,
                        OwnerEmail = t.OwnerEmail,
                        OwnerPhone = t.OwnerPhone,
                        StartTime = td.StartTime,
                        CloseTime = td.CloseTime,
                        Price = td.Price,
                        EventId = td.EventId,
                        TicketCode = t.TicketCode
                    }).ToList();

                // var ticketDtos = _mapper.Map<IEnumerable<TicketDto>>(tickets);

                return ticketDtos;
            }
            else
            {
                _db.Tickets.RemoveRange(tickets);
                _db.SaveChanges();
                return null;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<TicketDetailDto?> GetTicketDetailById(int ticketDetailId)
    {
        try
        {
            var ticketDetail = _db.TicketDetails.FirstOrDefault(td => td.Id == ticketDetailId);

            if (ticketDetail is null)
            {
                return null;
            }

            var ticketDetailDto = _mapper.Map<TicketDetailDto>(ticketDetail);

            return ticketDetailDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<TicketDetailDto?> GetTicketDetailByEventId(int eventId)
    {
        try
        {
            var ticketDetail = _db.TicketDetails.FirstOrDefault(td => td.EventId == eventId);

            if (ticketDetail is null)
            {
                return null;
            }

            var ticketDetailDto = _mapper.Map<TicketDetailDto>(ticketDetail);

            return ticketDetailDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> CreateTicketDetail(CreateTicketDetailDto createTicketDetailDto)
    {
        try
        {
            var newTicketDetail = _mapper.Map<TicketDetail>(createTicketDetailDto);

            await _db.TicketDetails.AddAsync(newTicketDetail);
            await _db.SaveChangesAsync();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> UpdateTicketDetail(int ticketDetailId, CreateTicketDetailDto updateTicketDetailDto)
    {
        try
        {
            var ticketDetail = _db.TicketDetails.FirstOrDefault(u => u.Id == ticketDetailId);

            if (ticketDetail is null)
            {
                return false;
            }

            ticketDetail.Quantity = updateTicketDetailDto.Quantity;
            ticketDetail.EventId = updateTicketDetailDto.EventId;
            ticketDetail.Price = updateTicketDetailDto.Price;
            ticketDetail.StartTime = updateTicketDetailDto.StartTime;
            ticketDetail.CloseTime = updateTicketDetailDto.CloseTime;

            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> UpdateTicketDetailByEventId(int eventId, CreateTicketDetailDto updateTicketDetailDto)
    {
        try
        {
            var ticketDetail = _db.TicketDetails.FirstOrDefault(u => u.EventId == eventId);

            if (ticketDetail is null)
            {
                return false;
            }

            ticketDetail.Quantity = updateTicketDetailDto.Quantity;
            ticketDetail.EventId = updateTicketDetailDto.EventId;
            ticketDetail.Price = updateTicketDetailDto.Price;
            ticketDetail.StartTime = updateTicketDetailDto.StartTime;
            ticketDetail.CloseTime = updateTicketDetailDto.CloseTime;

            _db.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}