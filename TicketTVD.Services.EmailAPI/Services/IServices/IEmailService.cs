using TicketTVD.Services.EmailAPI.Models.Dto;

namespace TicketTVD.Services.EmailAPI.Services.IServices;

public interface IEmailService
{
    Task RegisterUserEmailAndLog(string email);
    Task ValidateTicketEmailAndLog(ValidateStripeResponseDto ticket);
}