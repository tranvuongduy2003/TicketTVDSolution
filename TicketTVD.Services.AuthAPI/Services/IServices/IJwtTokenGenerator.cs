using TicketTVD.Services.AuthAPI.Models;

namespace TicketTVD.Services.AuthAPI.Services.IServices;

public interface IJwtTokenGenerator
{
    string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
}