namespace TicketTVD.Services.TicketAPI.Models.Dto;

public class TicketDto
{
    public int Id { get; set; }
    public int TicketDetailsId { get; set; }
    public string TicketCode { get; set; }
    public string OwnerName { get; set; }
    public string OwnerEmail { get; set; }
    public string OwnerPhone { get; set; }
    public int PaymentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}