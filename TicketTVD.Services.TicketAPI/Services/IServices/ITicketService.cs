using TicketTVD.Services.TicketAPI.Models.Dto;

namespace TicketTVD.Services.TicketAPI.Services.IServices;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>> GetTickets();
    Task<IEnumerable<TicketDetailDto>> GetTicketDetails();
    Task<TicketDto?> GetTicketById(int ticketId);
    Task<TicketDetailDto?> GetTicketDetailById(int ticketDetailId);
    Task<TicketDetailDto?> GetTicketDetailByEventId(int eventId);
}