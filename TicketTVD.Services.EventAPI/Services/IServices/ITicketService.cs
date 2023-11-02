using TicketTVD.Services.EventAPI.Models.Dto;

namespace TicketTVD.Services.EventAPI.Services.IServices;

public interface ITicketService
{
    Task<TicketDetailDto> GetTicketDetailByEventId(int eventId);
    Task<bool> CreateTicketDetail(CreateTicketDetailDto createTicketDetailDto);
    Task<bool> UpdateTicketDetailByEventId(int eventId, CreateTicketDetailDto createTicketDetailDto);
}