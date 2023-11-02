using System.Text;
using Newtonsoft.Json;
using TicketTVD.Services.EventAPI.Models.Dto;
using TicketTVD.Services.EventAPI.Services.IServices;

namespace TicketTVD.Services.EventAPI.Services;

public class TicketService : ITicketService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public TicketService(IHttpClientFactory clientFactory)
    {
        _httpClientFactory = clientFactory;
    }

    public async Task<TicketDetailDto> GetTicketDetailByEventId(int eventId)
    {
        var client = _httpClientFactory.CreateClient("TicketDetail");
        var response = await client.GetAsync($"/ticket-detail/event/{eventId}");
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<TicketDetailDto>(Convert.ToString(resp.Data));
        }

        return new TicketDetailDto();
    }

    public async Task<bool> CreateTicketDetail(CreateTicketDetailDto createTicketDetailDto)
    {
        var client = _httpClientFactory.CreateClient("TicketDetail");
        var response = await client.PostAsync("/ticket-detail",
            new StringContent(JsonConvert.SerializeObject(createTicketDetailDto), Encoding.UTF8, "application/json"));
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        return resp.IsSuccess;
    }

    public async Task<bool> UpdateTicketDetailByEventId(int eventId,
        CreateTicketDetailDto updateTicketDetailDto)
    {
        var client = _httpClientFactory.CreateClient("TicketDetail");
        var response = await client.PutAsync($"/ticket-detail/event/{eventId}",
            new StringContent(JsonConvert.SerializeObject(updateTicketDetailDto), Encoding.UTF8, "application/json"));
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        return resp.IsSuccess;
    }
}