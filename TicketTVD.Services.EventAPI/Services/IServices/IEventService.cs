using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI.Services.IServices;

public interface IEventService
{
    Task<IEnumerable<EventDto>> GetEvents();
    Task<DetailEventDto?> GetEventById(int eventId);
    Task<bool> CreateEvent(CreateEventDto createEventDto);
    Task<bool> UpdateEvent(int eventId, UpdateEventDto updateEventDto);
    Task<bool> DeleteEvent(int eventId);
}