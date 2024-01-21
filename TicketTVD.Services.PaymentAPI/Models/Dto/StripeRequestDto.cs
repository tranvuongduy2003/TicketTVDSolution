namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class StripeRequestDto
{
    public string? StripeSessionUrl { get; set; }
    public string? StripeSessionId { get; set; }
    public string ApprovedUrl { get; set; }
    public string CancelUrl { get; set; }
    public int PaymentId { get; set; }
    public IEnumerable<TicketDto>? Tickets { get; set; }
}