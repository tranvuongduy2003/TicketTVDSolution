using System.ComponentModel.DataAnnotations;

namespace TicketTVD.Services.AuthAPI.Models.Dto;

public class RefreshTokenRequestDto
{
    [Required]
    public string RefreshToken { get; set; }
}