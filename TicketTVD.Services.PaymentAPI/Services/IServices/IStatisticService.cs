using TicketTVD.Services.PaymentAPI.Models;

namespace TicketTVD.Services.PaymentAPI.Services.IServices;

public interface IStatisticService
{
    Task<IEnumerable<Revenue>> GetGeneralStatistic();
}