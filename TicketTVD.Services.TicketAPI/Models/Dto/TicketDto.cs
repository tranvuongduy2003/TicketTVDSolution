using System.Text.Json.Serialization;
using TicketTVD.Services.TicketAPI.Models.Enum;

namespace TicketTVD.Services.TicketAPI.Models.Dto;

public class TicketDto
{
    public int Id { get; set; }
    public string? TicketCode { get; set; }
    public string OwnerName { get; set; }
    public string OwnerEmail { get; set; }
    public string OwnerPhone { get; set; }
    public int EventId { get; set; }
    public decimal Price { get; set; }
    public bool IsPaid { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TicketStatus Status { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime CloseTime { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}