using System.ComponentModel.DataAnnotations;

namespace TicketTVD.Services.PaymentAPI.Models.Dto;

public class ContactInfoDto
{
    [Required]
    public string FullName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
}