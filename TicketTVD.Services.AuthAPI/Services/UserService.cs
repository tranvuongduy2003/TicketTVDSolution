﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Extensions;
using TicketTVD.Services.AuthAPI.Data;
using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Dto;
using TicketTVD.Services.AuthAPI.Services.IServices;

namespace TicketTVD.Services.AuthAPI.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IMapper _mapper;

    public UserService(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
        IMapper mapper)
    {
        _db = db;
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDto>> GetUsers()
    {
        try
        {
            var users = _db.ApplicationUsers.ToList();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);
            return userDtos;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<UserDto?> GetUserById(string userId)
    {
        try
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == userId);

            if (user is null)
            {
                return null;
            }

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<UserDto?> UpdateUser(string userId, UpdateUserDto updateUserDto)
    {
        try
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == userId);

            if (user is null)
            {
                return null;
            }

            var updatedUser = _mapper.Map<ApplicationUser>(updateUserDto);
            user.Name = updateUserDto.Name;
            user.Avatar = updateUserDto.Avatar;
            user.Email = updateUserDto.Email;
            user.Gender = updateUserDto.Gender;
            user.Status = updateUserDto.Status;
            user.PhoneNumber = updateUserDto.PhoneNumber;
            user.DOB = updateUserDto.DOB;
            user.UpdatedAt = DateTime.Now;
            _db.SaveChanges();

            if (!_roleManager.RoleExistsAsync(updateUserDto.Role.GetDisplayName()).GetAwaiter()
                    .GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(updateUserDto.Role.GetDisplayName()))
                    .GetAwaiter().GetResult();
            }

            var userRoles = await _userManager.GetRolesAsync(updatedUser);
            await _userManager.RemoveFromRolesAsync(updatedUser, userRoles);
            await _userManager.AddToRoleAsync(updatedUser, updateUserDto.Role.GetDisplayName());


            var updatedUserDto = _mapper.Map<UserDto>(updatedUser);
            return updatedUserDto;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<string?> UpdateUserPassword(string userId, UpdateUserPasswordDto updateUserPasswordDto)
    {
        try
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == userId);
            if (user is null)
            {
                return null;
            }

            bool isValid = await _userManager.CheckPasswordAsync(user, updateUserPasswordDto.OldPassword);
            if (!isValid)
            {
                return "Old password is wrong";
            }

            await _userManager.ChangePasswordAsync(user, updateUserPasswordDto.OldPassword,
                updateUserPasswordDto.NewPassword);

            user.UpdatedAt = DateTime.Now;
            _db.SaveChanges();

            return "";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}