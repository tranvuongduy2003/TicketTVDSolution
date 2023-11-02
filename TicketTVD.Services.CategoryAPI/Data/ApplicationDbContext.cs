using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.CategoryAPI.Models;

namespace TicketTVD.Services.CategoryAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        this.SeedCategories(modelBuilder);
    }

    private void SeedCategories(ModelBuilder builder)
    {
        builder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "Âm nhạc",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Category()
            {
                Id = 2,
                Name = "Thể thao",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Category()
            {
                Id = 3,
                Name = "Hội họa",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Category()
            {
                Id = 4,
                Name = "Doanh nghệp",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Category()
            {
                Id = 5,
                Name = "Nhiếp ảnh",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );
    }
}