using AutoMapper;
using TicketTVD.Services.TicketAPI.Data;
using TicketTVD.Services.TicketAPI.Models.Dto;
using TicketTVD.Services.TicketAPI.Services.IServices;

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
            var tickets = _db.Tickets.ToList();
            var ticketDtos = _mapper.Map<IEnumerable<TicketDto>>(tickets);

            return ticketDtos;
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
            var ticket = _db.Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticket is null)
            {
                return null;
            }
            
            var ticketDto = _mapper.Map<TicketDto>(ticket);

            return ticketDto;
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
}