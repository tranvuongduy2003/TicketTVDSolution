using TicketTVD.Services.PaymentAPI.Models.Dto;

namespace TicketTVD.Services.PaymentAPI.Services.IServices;

public interface IEventService
{
    Task<IEnumerable<EventDto>> GetEventsByTickets(EventsByTicketsDto eventsByTicketsDto);
}