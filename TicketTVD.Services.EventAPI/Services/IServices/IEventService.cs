using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI.Services.IServices;

public interface IEventService
{
    Task<IEnumerable<EventDto>> GetEvents(string? search);
    Task<IEnumerable<EventStatistic>> GetEventsStatisticByCategory();
    Task<IEnumerable<EventDto>> GetEventsByTickets(EventsByTicketsDto eventsByTicketsDto);
    Task<IEnumerable<EventDto>> GetEventsByOrganizerId(string organizerId);
    Task<DetailEventDto?> GetEventById(int eventId);
    Task<bool> CreateEvent(CreateEventDto createEventDto);
    Task<bool> UpdateEvent(int eventId, UpdateEventDto updateEventDto);
    Task<bool> DeleteEvent(int eventId);
    Task<bool> IncreaseFavourite(int id);
    Task<bool> DecreaseFavourite(int id);
    Task<bool> IncreaseShare(int id);
    Task<bool> DecreaseShare(int id);
}