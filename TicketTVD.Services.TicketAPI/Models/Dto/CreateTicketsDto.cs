namespace TicketTVD.Services.TicketAPI.Models.Dto;

public class CreateTicketsDto
{
    public IEnumerable<TicketDto>? Tickets { get; set; }
}