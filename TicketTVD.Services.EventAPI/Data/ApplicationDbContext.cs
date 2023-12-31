﻿using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.EventAPI.Models;
using TicketTVD.Services.EventAPI.Models.Enum;

namespace TicketTVD.Services.EventAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        this.SeedEvents(modelBuilder);
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Suite 97",
                EventDate = DateTime.Parse("2022-12-13T05:09:52Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Room 1255",
                EventDate =DateTime.Parse("2023-02-23T03:24:01Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Room 1341",
                EventDate = DateTime.Parse("2023-02-12T19:01:46Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "PO Box 21676",
                EventDate = DateTime.Parse("2023-03-25T14:47:16Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Suite 54",
                EventDate = DateTime.Parse("2023-01-16T10:17:12Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "PO Box 57974",
                EventDate = DateTime.Parse("2023-05-07T09:36:28Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "11th Floor",
                EventDate = DateTime.Parse("2022-12-06T04:04:02Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Room 1646",
                EventDate = DateTime.Parse("2023-01-09T20:21:03Z"),
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
                Description = "Bypass Cecum to Cutaneous with Nonautologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic",
                CategoryId = 4,
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "Room 209",
                EventDate = DateTime.Parse("2023-06-21T16:29:58Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "11th Floor",
                EventDate = DateTime.Parse("2023-05-30T11:15:06Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "1st Floor",
                EventDate = DateTime.Parse("2023-08-02T10:00:03Z"),
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
                Album = new List<string>()
                {
                    "http://dummyimage.com/189x100.png/5fa2dd/ffffff",
                    "http://dummyimage.com/169x100.png/dddddd/000000",
                    "http://dummyimage.com/183x100.png/ff4444/ffffff",
                    "http://dummyimage.com/106x100.png/cc0000/ffffff",
                    "http://dummyimage.com/119x100.png/ff4444/ffffff"
                },
                Location = "PO Box 86135",
                EventDate = DateTime.Parse("2023-01-10T13:02:29Z"),
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