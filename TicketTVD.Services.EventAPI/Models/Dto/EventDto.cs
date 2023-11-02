using System.Text.Json.Serialization;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Models.Dto;

public class EventDto
{
    public int Id { get; set; }
    public string CoverImage { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime EventDate { get; set; }
    public decimal TicketPrice { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}