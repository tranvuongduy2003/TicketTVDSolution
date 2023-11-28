using TicketTVD.Services.PaymentAPI.Models.Dto;

namespace TicketTVD.Services.PaymentAPI.Services;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>> GetTicketsByPaymentId(int paymentId);
    Task<IEnumerable<TicketDto>> CreateTickets(int paymentId, CreateTicketsDto createTicketsDto);
    Task<IEnumerable<TicketDto>> ValidateTickets(int paymentId, bool isSuccess);
}