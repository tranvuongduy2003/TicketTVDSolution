using Microsoft.AspNetCore.Identity;

namespace TicketTVD.Services.AuthAPI.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public DateTime DOD { get; set; }
    public string Gender { get; set; }
    public string Avatar { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}