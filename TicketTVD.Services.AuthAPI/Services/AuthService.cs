using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TicketTVD.Services.AuthAPI.Data;
using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Dto;
using TicketTVD.Services.AuthAPI.Services.IServices;

namespace TicketTVD.Services.AuthAPI.Services;

public class AuthService : IAuthService
{
    private readonly AppDbContext _db;
    private readonly ITokenService _tokenService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IMapper _mapper;

    public AuthService(AppDbContext db, ITokenService tokenService,
        UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
    {
        _db = db;
        _tokenService = tokenService;
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
    }
    
    public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
    {
        ApplicationUser user = new()
        {
            UserName = registrationRequestDto.Email,
            Email = registrationRequestDto.Email,
            NormalizedEmail = registrationRequestDto.Email.ToUpper(),
            Name = registrationRequestDto.Name,
            PhoneNumber = registrationRequestDto.PhoneNumber,
        };

        try
        {
            var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
            if (result.Succeeded)
            {
                var userToReturn = _db.ApplicationUsers.First(u => u.UserName == registrationRequestDto.Email);

                if (!_roleManager.RoleExistsAsync(registrationRequestDto.Role).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(registrationRequestDto.Role)).GetAwaiter().GetResult();
                }

                await _userManager.AddToRoleAsync(user, registrationRequestDto.Role);
                
                UserDto userDto = new()
                {
                    Email = userToReturn.Email,
                    ID = userToReturn.Id,
                    Name = userToReturn.Name,
                    PhoneNumber = userToReturn.PhoneNumber
                };

                return "";
            }
            else
            {
                return result.Errors.FirstOrDefault().Description;
            }
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

    public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
    {
        var user = _db.ApplicationUsers.FirstOrDefault(u =>
            u.Email.ToLower() == loginRequestDto.Email.ToLower());

        bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

        if (user == null || isValid == false)
        {
            return new LoginResponseDto() { User = null, RefreshToken = null, AccessToken = null };
        }

        //if user was found , Generate JWT Token
        var roles = await _userManager.GetRolesAsync(user);
        var accessToken = _tokenService.GenerateAccessToken(user, roles);
        var refreshToken = _tokenService.GenerateRefreshToken();

        user.RefreshToken = refreshToken;
        _db.SaveChanges();
        
        var userRoles = await _userManager.GetRolesAsync(user);
        
        var userDto = _mapper.Map<UserDto>(user);
        userDto.Role = userRoles.FirstOrDefault();

        LoginResponseDto loginResponseDto = new LoginResponseDto()
        {
            User = userDto,
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };

        return loginResponseDto;
    }

    public async Task<bool> AssignRole(string email, string roleName)
    {
        var user = _db.ApplicationUsers.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        if (user != null)
        {
            if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
            {
                //create role if it does not exist
                _roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
            }

            await _userManager.AddToRoleAsync(user, roleName);
            return true;
        }

        return false;
    }

    public async Task<string> RefreshToken(string accessToken, string refreshToken)
    {
        var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
        if (principal == null) return "";
        
        var userEmail = principal.Claims.FirstOrDefault(c =>  c.Type == ClaimTypes.Email).Value;
        var user = _db.ApplicationUsers.FirstOrDefault(u => u.Email.ToLower() == userEmail.ToLower());
        if (user is null || user.RefreshToken != refreshToken ||  _tokenService.ValidateTokenExpire(refreshToken))
            return "";
        
        var roles = await _userManager.GetRolesAsync(user);
        var newAccessToken = _tokenService.GenerateAccessToken(user, roles);

        return newAccessToken;
    }

    public async Task<UserDto?> GetUserProfile(string accessToken)
    {
        var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
        if (principal == null) return null;
        
        var userEmail = principal.Claims.FirstOrDefault(c =>  c.Type == ClaimTypes.Email).Value;
        var user = _db.ApplicationUsers.FirstOrDefault(u => u.Email.ToLower() == userEmail.ToLower());
        if (user is null) return null;

        var userRoles = await _userManager.GetRolesAsync(user);
        
        var userDto = _mapper.Map<UserDto>(user);
        userDto.Role = userRoles.FirstOrDefault();
        
        return userDto;
    }
}