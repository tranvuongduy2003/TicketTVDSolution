using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class RegistrationRequestDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string Password { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Role? Role { get; set; }
}