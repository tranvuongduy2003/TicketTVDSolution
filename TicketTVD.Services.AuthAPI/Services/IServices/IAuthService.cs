using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Dto;
using TicketTVD.Services.AuthAPI.Models.Enum;

namespace TicketTVD.Services.AuthAPI.Services.IServices;

public interface IAuthService
{
    Task<string> Register(RegistrationRequestDto registrationRequestDto);
    Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    Task<LoginResponseDto> OAuthLogin(OAuthLoginRequestDto oAuthLoginRequestDto);
    Task<bool> AssignRole(AssignRoleRequestDto model);
    Task<string> RefreshToken(string accessToken, string refreshToken);
    Task<UserDto?> GetUserProfile(string accessToken);
}
