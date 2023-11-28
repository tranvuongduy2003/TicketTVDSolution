using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<Album> Albums { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        this.SeedAlbums(modelBuilder);
        this.SeedEvents(modelBuilder);
    }

    private void SeedAlbums(ModelBuilder builder)
    {
        builder.Entity<Album>().HasData(
            new Album()
            {
                Id = 1,
                EventId = 1,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 2,
                EventId = 1,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 3,
                EventId = 1,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 4,
                EventId = 1,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 5,
                EventId = 1,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 6,
                EventId = 2,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 7,
                EventId = 2,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 8,
                EventId = 2,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 9,
                EventId = 2,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 10,
                EventId = 2,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 11,
                EventId = 3,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 12,
                EventId = 3,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 13,
                EventId = 3,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 14,
                EventId = 3,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 15,
                EventId = 3,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 16,
                EventId = 4,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 17,
                EventId = 4,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 18,
                EventId = 4,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 19,
                EventId = 4,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 20,
                EventId = 4,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 21,
                EventId = 5,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 22,
                EventId = 5,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 23,
                EventId = 5,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 24,
                EventId = 5,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 25,
                EventId = 5,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 26,
                EventId = 6,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 27,
                EventId = 6,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 28,
                EventId = 6,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 29,
                EventId = 6,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 30,
                EventId = 6,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 31,
                EventId = 7,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 32,
                EventId = 7,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 33,
                EventId = 7,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 34,
                EventId = 7,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 35,
                EventId = 7,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 36,
                EventId = 8,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 37,
                EventId = 8,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 38,
                EventId = 8,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 39,
                EventId = 8,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 40,
                EventId = 8,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 41,
                EventId = 9,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 42,
                EventId = 9,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 43,
                EventId = 9,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 44,
                EventId = 9,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 45,
                EventId = 9,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 46,
                EventId = 10,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 47,
                EventId = 10,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 48,
                EventId = 10,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 49,
                EventId = 10,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 50,
                EventId = 10,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 51,
                EventId = 11,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 52,
                EventId = 11,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 53,
                EventId = 11,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 54,
                EventId = 11,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 55,
                EventId = 11,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            },
            new Album()
            {
                Id = 56,
                EventId = 12,
                Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
            },
            new Album()
            {
                Id = 57,
                EventId = 12,
                Uri = "http://dummyimage.com/169x100.png/dddddd/000000",
            },
            new Album()
            {
                Id = 58,
                EventId = 12,
                Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff",
            },
            new Album()
            {
                Id = 59,
                EventId = 12,
                Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff",
            },
            new Album()
            {
                Id = 60,
                EventId = 12,
                Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
            }
        );
    }


    private void SeedEvents(ModelBuilder builder)
    {
        builder.Entity<Event>().HasData(
            new Event()
            {
                Id = 1,
                CoverImage = "http://dummyimage.com/146x100.png/dddddd/000000",
                Name = "Viviana Ellingworth",
                Description = "Drainage of Cerebellum with Drainage Device, Open Approach",
                CategoryId = 1,
                Location = "Suite 97",
                EventDate = DateTime.Parse("2022-12-13T05:09:52Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 28,
                PublishTime = DateTime.Parse("2024-03-22T14:56:35Z"),
                Favourite = 110,
                Share = 279,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 2,
                CoverImage = "http://dummyimage.com/212x100.png/5fa2dd/ffffff",
                Name = "Lucita Kite",
                Description = "Excision of Left Brachial Vein, Percutaneous Endoscopic Approach, Diagnostic",
                CategoryId = 2,
                Location = "Room 1255",
                EventDate = DateTime.Parse("2023-02-23T03:24:01Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 0,
                PublishTime = DateTime.Parse("2024-02-11T13:55:36Z"),
                Favourite = 113,
                Share = 287,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 3,
                CoverImage = "http://dummyimage.com/183x100.png/ff4444/ffffff",
                Name = "Edlin Doale",
                Description = "Revision of Autologous Tissue Substitute in Chest Wall, External Approach",
                CategoryId = 3,
                Location = "Room 1341",
                EventDate = DateTime.Parse("2023-02-12T19:01:46Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 76,
                PublishTime = DateTime.Parse("2024-01-29T02:02:34Z"),
                Favourite = 257,
                Share = 297,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 4,
                CoverImage = "http://dummyimage.com/119x100.png/ff4444/ffffff",
                Name = "Maitilde Finlason",
                Description = "Extirpation of Matter from Common Bile Duct, Open Approach",
                CategoryId = 4,
                Location = "PO Box 21676",
                EventDate = DateTime.Parse("2023-03-25T14:47:16Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 0,
                PublishTime = DateTime.Parse("2024-09-07T13:49:20Z"),
                Favourite = 8,
                Share = 111,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 5,
                CoverImage = "http://dummyimage.com/106x100.png/cc0000/ffffff",
                Name = "Elisabet Pasmore",
                Description = "Dilation of Left External Iliac Artery, Bifurcation, Percutaneous Endoscopic Approach",
                CategoryId = 5,
                Location = "Suite 54",
                EventDate = DateTime.Parse("2023-01-16T10:17:12Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 93,
                PublishTime = DateTime.Parse("2024-01-06T00:22:49Z"),
                Favourite = 35,
                Share = 124,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 6,
                CoverImage = "http://dummyimage.com/169x100.png/dddddd/000000",
                Name = "Nicolai Pinor",
                Description = "Immobilization of Right Lower Leg using Brace",
                CategoryId = 1,
                Location = "PO Box 57974",
                EventDate = DateTime.Parse("2023-05-07T09:36:28Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 0,
                PublishTime = DateTime.Parse("2024-01-18T07:55:19Z"),
                Favourite = 273,
                Share = 124,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 7,
                CoverImage = "http://dummyimage.com/180x100.png/5fa2dd/ffffff",
                Name = "Jorgan Donaghy",
                Description = "Dilation of Upper Artery with Drug-eluting Intraluminal Device, Percutaneous Approach",
                CategoryId = 2,
                Location = "11th Floor",
                EventDate = DateTime.Parse("2022-12-06T04:04:02Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 91,
                PublishTime = DateTime.Parse("2024-02-21T03:02:23Z"),
                Favourite = 261,
                Share = 10,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 8,
                CoverImage = "http://dummyimage.com/244x100.png/cc0000/ffffff",
                Name = "Sonya Goddert",
                Description = "Destruction of Right Shoulder Muscle, Open Approach",
                CategoryId = 3,
                Location = "Room 1646",
                EventDate = DateTime.Parse("2023-01-09T20:21:03Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 0,
                PublishTime = DateTime.Parse("2023-11-25T18:32:36Z"),
                Favourite = 16,
                Share = 66,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 9,
                CoverImage = "http://dummyimage.com/154x100.png/5fa2dd/ffffff",
                Name = "Simone Noblett",
                Description =
                    "Bypass Cecum to Cutaneous with Nonautologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic",
                CategoryId = 4,
                Location = "Room 209",
                EventDate = DateTime.Parse("2023-06-21T16:29:58Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 69,
                PublishTime = DateTime.Parse("2024-09-14T18:50:13Z"),
                Favourite = 6,
                Share = 113,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 10,
                CoverImage = "http://dummyimage.com/111x100.png/ff4444/ffffff",
                Name = "Myrilla De Bruin",
                Description = "Excision of Greater Omentum, Percutaneous Approach",
                CategoryId = 5,
                Location = "11th Floor",
                EventDate = DateTime.Parse("2023-05-30T11:15:06Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = false,
                PromotionPlan = 0,
                PublishTime = DateTime.Parse("2024-07-06T22:37:26Z"),
                Favourite = 186,
                Share = 193,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 11,
                CoverImage = "http://dummyimage.com/148x100.png/5fa2dd/ffffff",
                Name = "Isobel McIlroy",
                Description = "Supplement Left Foot Vein with Nonautologous Tissue Substitute, Open Approach",
                CategoryId = 1,
                Location = "1st Floor",
                EventDate = DateTime.Parse("2023-08-02T10:00:03Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 81,
                PublishTime = DateTime.Parse("2023-12-02T03:42:57Z"),
                Favourite = 287,
                Share = 193,
                Status = Status.UPCOMING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Event()
            {
                Id = 12,
                CoverImage = "http://dummyimage.com/213x100.png/5fa2dd/ffffff",
                Name = "Bradly Majury",
                Description = "Resection of Perineum Tendon, Open Approach",
                CategoryId = 2,
                Location = "PO Box 86135",
                EventDate = DateTime.Parse("2023-01-10T13:02:29Z"),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                IsPromotion = true,
                PromotionPlan = 95,
                PublishTime = DateTime.Parse("2023-12-15T05:37:54Z"),
                Favourite = 146,
                Share = 217,
                Status = Status.OPENING,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        );
    }
}