using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Dto;

namespace TicketTVD.Services.AuthAPI.Services.IServices;

public interface IAuthService
{
    Task<string> Register(RegistrationRequestDto registrationRequestDto);
    Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    Task<LoginResponseDto> LoginWithGoogle(LoginGoogleRequestDto loginGoogleRequestDto);
    Task<bool> AssignRole(string email, string roleName);
    Task<string> RefreshToken(string accessToken, string refreshToken);
    Task<UserDto?> GetUserProfile(string accessToken);
}
