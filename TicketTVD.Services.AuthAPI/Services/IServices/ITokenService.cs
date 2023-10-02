using System.Security.Claims;
using TicketTVD.Services.AuthAPI.Models;

namespace TicketTVD.Services.AuthAPI.Services.IServices;

public interface ITokenService
{
    string GenerateAccessToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    
    string GenerateRefreshToken();
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
    bool ValidateTokenExpire(string token);
}