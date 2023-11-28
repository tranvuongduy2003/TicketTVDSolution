using System.Text;
using Newtonsoft.Json;
using TicketTVD.Services.PaymentAPI.Models.Dto;

namespace TicketTVD.Services.PaymentAPI.Services;

public class TicketService : ITicketService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public TicketService(IHttpClientFactory clientFactory)
    {
        _httpClientFactory = clientFactory;
    }

    public async Task<IEnumerable<TicketDto>> GetTicketsByPaymentId(int paymentId)
    {
        var client = _httpClientFactory.CreateClient("Ticket");
        var response = await client.GetAsync($"/get-by-payment/{paymentId}");
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<IEnumerable<TicketDto>>(Convert.ToString(resp.Data));
        }

        return new List<TicketDto>();
    }

    public async Task<IEnumerable<TicketDto>> CreateTickets(int paymentId, CreateTicketsDto createTicketsDto)
    {
        var client = _httpClientFactory.CreateClient("Ticket");

        var request = new HttpRequestMessage(HttpMethod.Post, $"/create-tickets/{paymentId}")
        {
            Content = new StringContent(JsonConvert.SerializeObject(createTicketsDto), Encoding.UTF8, "application/json")
        };
        
        var response = await client.SendAsync(request);
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<IEnumerable<TicketDto>>(Convert.ToString(resp.Data));
        }

        return null;
    }

    public async Task<IEnumerable<TicketDto>> ValidateTickets(int paymentId, bool isSuccess)
    {
        var client = _httpClientFactory.CreateClient("Ticket");

        var request = new HttpRequestMessage(HttpMethod.Patch, $"/validate-tickets/{paymentId}")
        {
            Content = new StringContent(JsonConvert.SerializeObject(isSuccess), Encoding.UTF8, "application/json")
        };
        
        var response = await client.SendAsync(request);
        var apiContent = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
        if (resp.IsSuccess)
        {
            return JsonConvert.DeserializeObject<IEnumerable<TicketDto>>(Convert.ToString(resp.Data));
        }

        return null;
    }
}