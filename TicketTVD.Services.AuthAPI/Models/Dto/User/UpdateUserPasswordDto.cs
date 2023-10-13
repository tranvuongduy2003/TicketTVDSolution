﻿using System.ComponentModel.DataAnnotations;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class UpdateUserPasswordDto
{
    [Required]
    public string OldPassword { get; set; }
    [Required]
    public string NewPassword { get; set; }
}