namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class EventsByTicketsDto
{
    public string? Search { get; set; }
    public IEnumerable<int> EventIds { get; set; }
}