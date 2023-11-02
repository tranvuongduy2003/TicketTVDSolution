﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketTVD.Services.EventAPI.Data;

#nullable disable

namespace TicketTVD.Services.EventAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231102203110_AddEventMigration")]
    partial class AddEventMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketTVD.Services.EventAPI.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventId = 1,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 2,
                            EventId = 1,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 3,
                            EventId = 1,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 4,
                            EventId = 1,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 5,
                            EventId = 1,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 6,
                            EventId = 2,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 7,
                            EventId = 2,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 8,
                            EventId = 2,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 9,
                            EventId = 2,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 10,
                            EventId = 2,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 11,
                            EventId = 3,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 12,
                            EventId = 3,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 13,
                            EventId = 3,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 14,
                            EventId = 3,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 15,
                            EventId = 3,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 16,
                            EventId = 4,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 17,
                            EventId = 4,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 18,
                            EventId = 4,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 19,
                            EventId = 4,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 20,
                            EventId = 4,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 21,
                            EventId = 5,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 22,
                            EventId = 5,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 23,
                            EventId = 5,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 24,
                            EventId = 5,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 25,
                            EventId = 5,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 26,
                            EventId = 6,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 27,
                            EventId = 6,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 28,
                            EventId = 6,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 29,
                            EventId = 6,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 30,
                            EventId = 6,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 31,
                            EventId = 7,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 32,
                            EventId = 7,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 33,
                            EventId = 7,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 34,
                            EventId = 7,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 35,
                            EventId = 7,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 36,
                            EventId = 8,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 37,
                            EventId = 8,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 38,
                            EventId = 8,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 39,
                            EventId = 8,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 40,
                            EventId = 8,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 41,
                            EventId = 9,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 42,
                            EventId = 9,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 43,
                            EventId = 9,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 44,
                            EventId = 9,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 45,
                            EventId = 9,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 46,
                            EventId = 10,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 47,
                            EventId = 10,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 48,
                            EventId = 10,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 49,
                            EventId = 10,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 50,
                            EventId = 10,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 51,
                            EventId = 11,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 52,
                            EventId = 11,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 53,
                            EventId = 11,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 54,
                            EventId = 11,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 55,
                            EventId = 11,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 56,
                            EventId = 12,
                            Uri = "http://dummyimage.com/189x100.png/5fa2dd/ffffff"
                        },
                        new
                        {
                            Id = 57,
                            EventId = 12,
                            Uri = "http://dummyimage.com/169x100.png/dddddd/000000"
                        },
                        new
                        {
                            Id = 58,
                            EventId = 12,
                            Uri = "http://dummyimage.com/183x100.png/ff4444/ffffff"
                        },
                        new
                        {
                            Id = 59,
                            EventId = 12,
                            Uri = "http://dummyimage.com/106x100.png/cc0000/ffffff"
                        },
                        new
                        {
                            Id = 60,
                            EventId = 12,
                            Uri = "http://dummyimage.com/119x100.png/ff4444/ffffff"
                        });
                });

            modelBuilder.Entity("TicketTVD.Services.EventAPI.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Favourite")
                        .HasColumnType("int");

                    b.Property<bool>("IsPromotion")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PromotionPlan")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Share")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CoverImage = "http://dummyimage.com/146x100.png/dddddd/000000",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(106),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Drainage of Cerebellum with Drainage Device, Open Approach",
                            EventDate = new DateTime(2022, 12, 13, 12, 9, 52, 0, DateTimeKind.Local),
                            Favourite = 110,
                            IsPromotion = true,
                            Location = "Suite 97",
                            Name = "Viviana Ellingworth",
                            PromotionPlan = 28,
                            PublishTime = new DateTime(2024, 3, 22, 21, 56, 35, 0, DateTimeKind.Local),
                            Share = 279,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(114)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CoverImage = "http://dummyimage.com/212x100.png/5fa2dd/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(126),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Excision of Left Brachial Vein, Percutaneous Endoscopic Approach, Diagnostic",
                            EventDate = new DateTime(2023, 2, 23, 10, 24, 1, 0, DateTimeKind.Local),
                            Favourite = 113,
                            IsPromotion = false,
                            Location = "Room 1255",
                            Name = "Lucita Kite",
                            PromotionPlan = 0,
                            PublishTime = new DateTime(2024, 2, 11, 20, 55, 36, 0, DateTimeKind.Local),
                            Share = 287,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(127)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CoverImage = "http://dummyimage.com/183x100.png/ff4444/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(136),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Revision of Autologous Tissue Substitute in Chest Wall, External Approach",
                            EventDate = new DateTime(2023, 2, 13, 2, 1, 46, 0, DateTimeKind.Local),
                            Favourite = 257,
                            IsPromotion = true,
                            Location = "Room 1341",
                            Name = "Edlin Doale",
                            PromotionPlan = 76,
                            PublishTime = new DateTime(2024, 1, 29, 9, 2, 34, 0, DateTimeKind.Local),
                            Share = 297,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(136)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CoverImage = "http://dummyimage.com/119x100.png/ff4444/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(145),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Extirpation of Matter from Common Bile Duct, Open Approach",
                            EventDate = new DateTime(2023, 3, 25, 21, 47, 16, 0, DateTimeKind.Local),
                            Favourite = 8,
                            IsPromotion = false,
                            Location = "PO Box 21676",
                            Name = "Maitilde Finlason",
                            PromotionPlan = 0,
                            PublishTime = new DateTime(2024, 9, 7, 20, 49, 20, 0, DateTimeKind.Local),
                            Share = 111,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(146)
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CoverImage = "http://dummyimage.com/106x100.png/cc0000/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(154),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Dilation of Left External Iliac Artery, Bifurcation, Percutaneous Endoscopic Approach",
                            EventDate = new DateTime(2023, 1, 16, 17, 17, 12, 0, DateTimeKind.Local),
                            Favourite = 35,
                            IsPromotion = true,
                            Location = "Suite 54",
                            Name = "Elisabet Pasmore",
                            PromotionPlan = 93,
                            PublishTime = new DateTime(2024, 1, 6, 7, 22, 49, 0, DateTimeKind.Local),
                            Share = 124,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(154)
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            CoverImage = "http://dummyimage.com/169x100.png/dddddd/000000",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(164),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Immobilization of Right Lower Leg using Brace",
                            EventDate = new DateTime(2023, 5, 7, 16, 36, 28, 0, DateTimeKind.Local),
                            Favourite = 273,
                            IsPromotion = false,
                            Location = "PO Box 57974",
                            Name = "Nicolai Pinor",
                            PromotionPlan = 0,
                            PublishTime = new DateTime(2024, 1, 18, 14, 55, 19, 0, DateTimeKind.Local),
                            Share = 124,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(164)
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CoverImage = "http://dummyimage.com/180x100.png/5fa2dd/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(173),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Dilation of Upper Artery with Drug-eluting Intraluminal Device, Percutaneous Approach",
                            EventDate = new DateTime(2022, 12, 6, 11, 4, 2, 0, DateTimeKind.Local),
                            Favourite = 261,
                            IsPromotion = false,
                            Location = "11th Floor",
                            Name = "Jorgan Donaghy",
                            PromotionPlan = 91,
                            PublishTime = new DateTime(2024, 2, 21, 10, 2, 23, 0, DateTimeKind.Local),
                            Share = 10,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(173)
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CoverImage = "http://dummyimage.com/244x100.png/cc0000/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(181),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Destruction of Right Shoulder Muscle, Open Approach",
                            EventDate = new DateTime(2023, 1, 10, 3, 21, 3, 0, DateTimeKind.Local),
                            Favourite = 16,
                            IsPromotion = false,
                            Location = "Room 1646",
                            Name = "Sonya Goddert",
                            PromotionPlan = 0,
                            PublishTime = new DateTime(2023, 11, 26, 1, 32, 36, 0, DateTimeKind.Local),
                            Share = 66,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(181)
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            CoverImage = "http://dummyimage.com/154x100.png/5fa2dd/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(190),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Bypass Cecum to Cutaneous with Nonautologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic",
                            EventDate = new DateTime(2023, 6, 21, 23, 29, 58, 0, DateTimeKind.Local),
                            Favourite = 6,
                            IsPromotion = true,
                            Location = "Room 209",
                            Name = "Simone Noblett",
                            PromotionPlan = 69,
                            PublishTime = new DateTime(2024, 9, 15, 1, 50, 13, 0, DateTimeKind.Local),
                            Share = 113,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(190)
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            CoverImage = "http://dummyimage.com/111x100.png/ff4444/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(198),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Excision of Greater Omentum, Percutaneous Approach",
                            EventDate = new DateTime(2023, 5, 30, 18, 15, 6, 0, DateTimeKind.Local),
                            Favourite = 186,
                            IsPromotion = false,
                            Location = "11th Floor",
                            Name = "Myrilla De Bruin",
                            PromotionPlan = 0,
                            PublishTime = new DateTime(2024, 7, 7, 5, 37, 26, 0, DateTimeKind.Local),
                            Share = 193,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(198)
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            CoverImage = "http://dummyimage.com/148x100.png/5fa2dd/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(206),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Supplement Left Foot Vein with Nonautologous Tissue Substitute, Open Approach",
                            EventDate = new DateTime(2023, 8, 2, 17, 0, 3, 0, DateTimeKind.Local),
                            Favourite = 287,
                            IsPromotion = true,
                            Location = "1st Floor",
                            Name = "Isobel McIlroy",
                            PromotionPlan = 81,
                            PublishTime = new DateTime(2023, 12, 2, 10, 42, 57, 0, DateTimeKind.Local),
                            Share = 193,
                            Status = 0,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(206)
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            CoverImage = "http://dummyimage.com/213x100.png/5fa2dd/ffffff",
                            CreatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(213),
                            CreatorId = "b74ddd14-6340-4840-95c2-db1255484302",
                            Description = "Resection of Perineum Tendon, Open Approach",
                            EventDate = new DateTime(2023, 1, 10, 20, 2, 29, 0, DateTimeKind.Local),
                            Favourite = 146,
                            IsPromotion = true,
                            Location = "PO Box 86135",
                            Name = "Bradly Majury",
                            PromotionPlan = 95,
                            PublishTime = new DateTime(2023, 12, 15, 12, 37, 54, 0, DateTimeKind.Local),
                            Share = 217,
                            Status = 1,
                            UpdatedAt = new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(214)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
