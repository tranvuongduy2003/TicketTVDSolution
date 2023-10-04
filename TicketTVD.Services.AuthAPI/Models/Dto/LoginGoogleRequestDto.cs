namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class LoginGoogleRequestDto
{
    public string Email { get; set; }
    public string? Avatar { get; set; }
    public string Name { get; set; }
    public DateTime TokenExpiredDate { get; set; }
}