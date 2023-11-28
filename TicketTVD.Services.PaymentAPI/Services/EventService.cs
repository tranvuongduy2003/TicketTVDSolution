using System.Text;
using Newtonsoft.Json;
using TicketTVD.Services.PaymentAPI.Models.Dto;
using TicketTVD.Services.PaymentAPI.Services.IServices;

namespace TicketTVD.Services.PaymentAPI.Services;

public class EventService : IEventService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public EventService(IHttpClientFactory clientFactory)
    {
        _httpClientFactory = clientFactory;
    }
    
    public async Task<IEnumerable<EventDto>> GetEventsByTickets(EventsByTicketsDto eventsByTicketsDto)
    {
        var client = _httpClientFactory.CreateClient("Event");
    
        var request = new HttpRequestMessage(HttpMethod.Post, "/get-events-by-tickets")
        {
            Content = new StringContent(JsonConvert.SerializeObject(eventsByTicketsDto), Encoding.UTF8, "application/json")
        };
        
        var response = await client.SendAsync(request);
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<IEnumerable<EventDto>>(Convert.ToString(resp.Data));
        }
    
        return null;
    }
}