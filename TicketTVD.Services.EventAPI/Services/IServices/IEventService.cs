using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI.Services.IServices;

public interface IEventService
{
    Task<IEnumerable<EventDto>> GetEvents();
    Task<EventDto?> GetEventById(int eventId);
    Task<EventDto?> CreateEvent(CreateEventDto createEventDto);
    Task<EventDto?> UpdateEvent(int eventId, UpdateEventDto updateEventDto);
    Task<bool> DeleteEvent(int eventId);
}