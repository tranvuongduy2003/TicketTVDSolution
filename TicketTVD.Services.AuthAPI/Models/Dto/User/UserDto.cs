using System.Text.Json.Serialization;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class UserDto
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? DOB { get; set; }
    public string? Gender { get; set; }
    public string? Avatar { get; set; }
    public int? TotalBuyedTickets { get; set; }
    public int? TotalEvents { get; set; }
    public int? TotalSoldTickets { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Role Role { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}