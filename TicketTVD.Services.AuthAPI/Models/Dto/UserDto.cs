namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class UserDto
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime? DOB { get; set; }
    public string? Gender { get; set; }
    public string? Avatar { get; set; }
    public string Status { get; set; }
    public string Role { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}