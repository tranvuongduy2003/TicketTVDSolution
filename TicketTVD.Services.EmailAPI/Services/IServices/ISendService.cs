namespace TicketTVD.Services.EmailAPI.Services.IServices;

public interface ISendService
{
    Task SendEmail(string destinationEmail, string subject, string body);
}