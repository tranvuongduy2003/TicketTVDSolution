using System.Text.Json.Serialization;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Models.Dto;

public class UpdateEventDto
{
    public int Id { get; set; }
    public string CoverImage { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public IEnumerable<string> Album { get; set; }
    
    public string Location { get; set; }
    public DateTime EventDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public int TicketTypeId { get; set; }
    public Boolean TicketIsPaid { get; set; }
    public int TicketQuantity { get; set; }
    public decimal? TicketPrice { get; set; }
    public decimal TicketStartTime { get; set; }
    public decimal TicketCloseTime { get; set; }
    
    public Boolean IsPromotion { get; set; }
    public int? PromotionPlan { get; set; }
    
    public DateTime PublishTime { get; set; }
    
    public string CreatorId { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
}