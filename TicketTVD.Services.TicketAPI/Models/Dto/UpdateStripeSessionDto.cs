namespace TicketTVD.Services.TicketAPI.Models.Dto;

public class UpdateStripeSessionDto
{
    public IEnumerable<TicketDto> Tickets { get; set; }
    public string SessionId { get; set; }
}