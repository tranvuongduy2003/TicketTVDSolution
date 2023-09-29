using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.AuthAPI.Models;

namespace TicketTVD.Services.AuthAPI.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ApplicationUser>()
            .Property(e => e.CreatedAt)
            .HasDefaultValueSql("getdate()");

        modelBuilder.Entity<ApplicationUser>()
            .Property(e => e.UpdatedAt)
            .HasDefaultValueSql("getdate()");
    }
}