using TicketTVD.Services.AuthAPI.Models.Dto;

namespace TicketTVD.Services.AuthAPI.Services.IServices;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetUsers();
    Task<UserDto?> GetUserById(string userId);
    Task<UserDto?> UpdateUser(string userId, UpdateUserDto updateUserDto);
    Task<string?> UpdateUserPassword(string userId, UpdateUserPasswordDto updateUserPasswordDto);
}