using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.TicketAPI.Models;

namespace TicketTVD.Services.TicketAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketDetail> TicketDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        this.SeedTicketDetails(modelBuilder);
    }

    private void SeedTicketDetails(ModelBuilder builder)
    {
        builder.Entity<TicketDetail>().HasData(
            new TicketDetail()
            {
                Id = 1,
                EventId = 1,
                IsPaid = false,
                Quantity = 161,
                Price = 0,
                StartTime = DateTime.Parse("2022-12-13T05:09:52Z"),
                CloseTime = DateTime.Parse("2023-09-20T12:23:30Z")
            },
            new TicketDetail()
            {
                Id = 2,
                EventId = 2,
                IsPaid = false,
                Quantity = 79,
                Price = 0,
                StartTime = DateTime.Parse("2023-02-23T03:24:01Z"),
                CloseTime = DateTime.Parse("2023-07-28T18:42:35Z")
            },
            new TicketDetail()
            {
                Id = 3,
                EventId = 3,
                IsPaid = true,
                Quantity = 103,
                Price = 4221000,
                StartTime = DateTime.Parse("2023-02-12T19:01:46Z"),
                CloseTime = DateTime.Parse("2023-08-14T02:28:45Z")
            },
            new TicketDetail()
            {
                Id = 4,
                EventId = 4,
                IsPaid = false,
                Quantity = 30,
                Price = 0,
                StartTime = DateTime.Parse("2023-03-25T14:47:16Z"),
                CloseTime = DateTime.Parse("2023-05-14T01:10:46Z")
            },
            new TicketDetail()
            {
                Id = 5,
                EventId = 5,
                IsPaid = true,
                Quantity = 13,
                Price = 4684000,
                StartTime = DateTime.Parse("2023-01-16T10:17:12Z"),
                CloseTime = DateTime.Parse("2023-05-27T10:21:44Z")
            },
            new TicketDetail()
            {
                Id = 6,
                EventId = 6,
                IsPaid = true,
                Quantity = 61,
                Price = 8166000,
                StartTime = DateTime.Parse("2023-05-07T09:36:28Z"),
                CloseTime = DateTime.Parse("2023-05-15T17:12:02Z")
            },
            new TicketDetail()
            {
                Id = 7,
                EventId = 7,
                IsPaid = false,
                Quantity = 196,
                Price = 0,
                StartTime = DateTime.Parse("2022-12-06T04:04:02Z"),
                CloseTime = DateTime.Parse("2023-07-18T06:07:55Z")
            },
            new TicketDetail()
            {
                Id = 8,
                EventId = 8,
                IsPaid = false,
                Quantity = 51,
                Price = 0,
                StartTime = DateTime.Parse("2023-01-09T20:21:03Z"),
                CloseTime = DateTime.Parse("2023-08-20T15:51:14Z"),
            },
            new TicketDetail()
            {
                Id = 9,
                EventId = 9,
                IsPaid = false,
                Quantity = 8,
                Price = 0,
                StartTime = DateTime.Parse("2023-06-21T16:29:58Z"),
                CloseTime = DateTime.Parse("2023-08-16T07:51:26Z"),
            },
            new TicketDetail()
            {
                Id = 10,
                EventId = 10,
                IsPaid = false,
                Quantity = 20,
                Price = 0,
                StartTime = DateTime.Parse("2023-05-30T11:15:06Z"),
                CloseTime = DateTime.Parse("2023-10-27T12:37:21Z"),
            },
            new TicketDetail()
            {
                Id = 11,
                EventId = 11,
                IsPaid = false,
                Quantity = 130,
                Price = 0,
                StartTime = DateTime.Parse("2023-08-02T10:00:03Z"),
                CloseTime = DateTime.Parse("2023-08-21T21:27:24Z"),
            },
            new TicketDetail()
            {
                Id = 12,
                EventId = 12,
                IsPaid = true,
                Quantity = 15,
                Price = 9620000,
                StartTime = DateTime.Parse("2023-01-10T13:02:29Z"),
                CloseTime = DateTime.Parse("2023-01-27T18:21:17Z")
            }
        );
    }
}