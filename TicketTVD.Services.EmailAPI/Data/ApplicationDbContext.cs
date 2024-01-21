using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.EmailAPI.Models;

namespace TicketTVD.Services.EmailAPI.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<EmailLogger> EmailLoggers { get; set; }
}