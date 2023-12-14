using TicketTVD.Services.TicketAPI.Models.Dto;

namespace TicketTVD.Services.TicketAPI.Services.IServices;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>> GetTickets();
    Task<IEnumerable<TicketDetailDto>> GetTicketDetails();
    Task<TicketDto?> GetTicketById(int ticketId);
    Task<TicketDto?> UpdateTicketInfo(int ticketId, UdpateTicketDto updateTicketDto);
    Task<IEnumerable<TicketDto>> GetTicketsByPaymentId(int paymentId);
    Task<IEnumerable<TicketDto>> CreateTickets(int paymentId, CreateTicketsDto createTicketsDto);
    Task<IEnumerable<TicketDto>> ValidateTickets(int paymentId, bool isSuccess);
    Task<TicketDto?> TerminateTicket(int ticketId);
    Task<TicketDetailDto?> GetTicketDetailById(int ticketDetailId);
    Task<TicketDetailDto?> GetTicketDetailByEventId(int eventId);
    Task<bool> CreateTicketDetail(CreateTicketDetailDto createTicketDetailDto);
    Task<bool> UpdateTicketDetail(int ticketDetailId,CreateTicketDetailDto updateTicketDetailDto);
    Task<bool> UpdateTicketDetailByEventId(int eventId,CreateTicketDetailDto updateTicketDetailDto);
}