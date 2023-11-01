using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public DateTime? DOB { get; set; } = null;
    public string? Gender { get; set; }
    public string? Avatar { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; } = Status.ACTIVE;
    public string? RefreshToken { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}