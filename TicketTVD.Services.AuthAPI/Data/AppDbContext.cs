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

    public override Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        var AddedEntities = ChangeTracker.Entries()
            .Where(E => E.State == EntityState.Added && E.Entity is ApplicationUser)
            .ToList();
    
        AddedEntities.ForEach(E => { E.Property("CreatedAt").CurrentValue = DateTime.Now; });
    
        var EditedEntities = ChangeTracker.Entries()
            .Where(E => E.State == EntityState.Modified)
            .ToList();
    
        EditedEntities.ForEach(E => { E.Property("UpdatedAt").CurrentValue = DateTime.Now; });
    
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ApplicationUser>()
            .Property(b => b.CreatedAt)
            .HasDefaultValueSql("getdate()")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<ApplicationUser>()
            .Property(b => b.UpdatedAt)
            .HasDefaultValueSql("getdate()")
            .ValueGeneratedOnUpdate();
    }
}