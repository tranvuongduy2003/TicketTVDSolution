namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class UpdateStripeSessionDto
{
    public IEnumerable<TicketDto> Tickets { get; set; }
    public string SessionId { get; set; }
}