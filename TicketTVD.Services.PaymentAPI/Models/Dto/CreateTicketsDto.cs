namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class CreateTicketsDto
{
    public IEnumerable<TicketDto>? Tickets { get; set; }
}