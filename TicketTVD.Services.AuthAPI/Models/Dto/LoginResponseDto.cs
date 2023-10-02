namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class LoginResponseDto
{
    public UserDto User { get; set; }
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}