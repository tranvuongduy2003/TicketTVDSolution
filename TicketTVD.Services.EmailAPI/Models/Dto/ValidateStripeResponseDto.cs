namespace TicketTVD.Services.EmailAPI.Models.Dto;

public class ValidateStripeResponseDto
{
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public double Discount { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public IEnumerable<TicketDto>? Tickets { get; set; }
}