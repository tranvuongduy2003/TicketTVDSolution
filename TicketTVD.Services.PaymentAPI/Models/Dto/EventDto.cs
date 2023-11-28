using System.Text.Json.Serialization;
using TicketTVD.Services.PaymentAPI.Models.Enum;

namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class EventDto
{
    public int Id { get; set; }
    public string CoverImage { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CategoryId { get; set; }
    public string Location { get; set; }
    public DateTime EventDate { get; set; }
    public bool IsPromotion { get; set; }
    public int? PromotionPlan { get; set; }
    public decimal TicketPrice { get; set; }
    public int TicketSoldQuantity { get; set; }
    public int TicketQuantity { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EventStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}