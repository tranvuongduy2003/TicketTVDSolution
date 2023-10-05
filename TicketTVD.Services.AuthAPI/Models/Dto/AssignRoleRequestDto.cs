using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class AssignRoleRequestDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Role Role { get; set; }
}