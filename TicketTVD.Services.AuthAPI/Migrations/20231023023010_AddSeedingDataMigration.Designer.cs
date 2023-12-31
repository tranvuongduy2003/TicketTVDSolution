﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketTVD.Services.AuthAPI.Data;

#nullable disable

namespace TicketTVD.Services.AuthAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231023023010_AddSeedingDataMigration")]
    partial class AddSeedingDataMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09",
                            ConcurrencyStamp = "1",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            ConcurrencyStamp = "2",
                            Name = "CUSTOMER",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "3",
                            Name = "ORGANIZER",
                            NormalizedName = "ORGANIZER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484301",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484302",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484303",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484304",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484305",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484306",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484307",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484308",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484309",
                            RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                        },
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db1255484310",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TicketTVD.Services.AuthAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("Provider")
                        .HasColumnType("int");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "4a5cfc22-0b23-4e2c-99d5-85731448fea1",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5864),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5836),
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "Admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEM9R5ZTDtHd3xlf4yi8MzL5QS88Gc4s/2aK/zmmZbERhnFAEfCtreULg94NMtUj82g==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ffc5bae-dc96-4023-aabf-04ee9cff895c",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5870)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484301",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "f2653fdb-fe9c-4ec1-8517-5a96fba157c1",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1602),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1573),
                            Email = "user1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User1",
                            PasswordHash = "AQAAAAIAAYagAAAAELe2nA29s2P1ooozDVM4XYQ4ASI3gBU+Hyq0kcp7KwflnH8MVB8I/ZarGvc6ZFC39w==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b74dbf49-e3ce-4d84-871c-631646829be1",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1615)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484302",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "9e231724-48dc-4abe-a8a9-d01e58977e3c",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8320),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8289),
                            Email = "user2@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User2",
                            PasswordHash = "AQAAAAIAAYagAAAAEE18GX1NxmcfnDKCkLPoaf8WXOazfOgeNyNHrfSQbNskLHVq69yHi6/d9xU4TAn1nQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "62878b71-0541-4bac-bfd4-0a71b40cb177",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8321)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484303",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "6f68b494-836c-45ba-b560-a530e7e756ec",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5694),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5655),
                            Email = "user3@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User3",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ4kZsc38uI5SW7kLQTBytQUiaIak3elCbV9iYy4sXXSS2pnS6jgzLRkPtckdGgm+w==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "120146bb-0bdf-40ba-a616-1a22eae29167",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5696)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484304",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "5a8910a7-0fa6-4d0f-aa77-45f9cfe07547",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(8007),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(7978),
                            Email = "user4@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User4",
                            PasswordHash = "AQAAAAIAAYagAAAAEK/da/hkSDwbHNK/onsfSHNyUUqUt5LUyWTastRL5ooPpCuK5NTIVtIu1v09MQVFAg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "88f7e75a-973b-437a-8e05-fba171042184",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(8008)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484305",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "04d2687d-0839-4103-b4fc-c8856218991c",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4351),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4318),
                            Email = "user5@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User5",
                            PasswordHash = "AQAAAAIAAYagAAAAEFSYMNNDrNSM1lQNt/1qPj0/mmtCozcnB2UrmBqj1/YVnYprFeUOWHpRMcYHMUim0w==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1e51eb8-4c0d-4940-9836-b3446a172190",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4352)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484306",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "8e943618-d092-4215-92ba-51d4cc958c08",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5356),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5328),
                            Email = "user6@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User6",
                            PasswordHash = "AQAAAAIAAYagAAAAEFePFM1Z2KAWyYDlw2djJ5zI4AumKyCbgNoqoHuDC460r6I4xUMb52QoXmvxhqOdKg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "40e89551-661c-4b8e-8ef8-b22b7c13841f",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5357)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484307",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "51d10e16-9e6a-4a2c-bf55-907287297e72",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3027),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3000),
                            Email = "user7@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User7",
                            PasswordHash = "AQAAAAIAAYagAAAAEPnTNEa9Je9KM2tmtsKNga1IzNMoLz2ZD3v3lirw9/NwFiK3891i+bSyZAMBkruV+A==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "43be6f0b-8642-4559-9673-313e49b7615b",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3028)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484308",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "6f1e7290-71dc-4815-8604-a0115296f4bb",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9810),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9795),
                            Email = "user8@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User8",
                            PasswordHash = "AQAAAAIAAYagAAAAEBAPAQhRmeza1G6EjCVaeOSmokt1LU7+LOkYb7xAW65NWlAR6JRjzKUvqkvfAJ+tXg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4a141d40-6b56-403e-89ac-34f418c0bb5a",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9812)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484309",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "a1fa143f-f8b3-4d1e-9db2-bca90671da3c",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1052),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1035),
                            Email = "user9@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User9",
                            PasswordHash = "AQAAAAIAAYagAAAAEE4+oz47LUyiqkbeK1zkwbKJUtOdcbB3ImbzBlZCCUbb/nZFR5tYMjB0xoQ/WzwEOA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e78ec82a-d4d1-440d-8a0d-abc09fae9b84",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1054)
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db1255484310",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "e2be757f-e3cb-4e27-b6a6-685675e1cd9c",
                            CreatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2980),
                            DOB = new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2966),
                            Email = "user10@gmail.com",
                            EmailConfirmed = false,
                            Gender = "MALE",
                            LockoutEnabled = false,
                            Name = "User9",
                            PasswordHash = "AQAAAAIAAYagAAAAEAaJHfwcDZGJZ5DDYxoq7qHPYmTd9E97daVmRUvNY3ipmCOtSpS4wogTX8g/rzWeXw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3e4c04e5-fdf5-4c20-9f9b-3eed10ea7e3a",
                            Status = 0,
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2982)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TicketTVD.Services.AuthAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TicketTVD.Services.AuthAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketTVD.Services.AuthAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TicketTVD.Services.AuthAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
