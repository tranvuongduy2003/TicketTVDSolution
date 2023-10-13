using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TicketTVD.Services.AuthAPI.Models.Enum;
namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class OAuthLoginRequestDto
{
    [Required]
    public string? Email { get; set; }
    public string? Avatar { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Provider Provider { get; set; }
    [Required]
    public DateTime TokenExpiredDate { get; set; }
}