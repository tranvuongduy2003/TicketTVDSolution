using TicketTVD.Services.PaymentAPI.Models.Enum;

namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class ValidateStripeResponseDto
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal EventId { get; set; }
    public double Discount { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public Status Status { get; set; }
    public PaymentMethodDto PaymentMethod { get; set; }
    public IEnumerable<TicketDto>? Tickets { get; set; }
    public string? PaymentIntentId { get; set; }
    public string? StripeSessionId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}