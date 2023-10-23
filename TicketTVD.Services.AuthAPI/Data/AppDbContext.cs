using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketTVD.Services.AuthAPI.Models;
using TicketTVD.Services.AuthAPI.Models.Enum;

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
        this.SeedUsers(modelBuilder);
        this.SeedRoles(modelBuilder);
        this.SeedUserRoles(modelBuilder);
    }

    private void SeedUsers(ModelBuilder builder)
    {
        List<ApplicationUser> users = new List<ApplicationUser>();
        PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();

        ApplicationUser admin = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
            Name = "Admin",
            Email = "admin@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
        };
        admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin*123");
        users.Add(admin);

        ApplicationUser user1 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484301",
            Name = "User1",
            Email = "user1@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user1.PasswordHash = passwordHasher.HashPassword(user1, "User*123");
        users.Add(user1);

        ApplicationUser user2 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484302",
            Name = "User2",
            Email = "user2@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user2.PasswordHash = passwordHasher.HashPassword(user2, "User*123");
        users.Add(user2);

        ApplicationUser user3 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484303",
            Name = "User3",
            Email = "user3@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user3.PasswordHash = passwordHasher.HashPassword(user3, "User*123");
        users.Add(user3);

        ApplicationUser user4 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484304",
            Name = "User4",
            Email = "user4@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user4.PasswordHash = passwordHasher.HashPassword(user4, "User*123");
        users.Add(user4);

        ApplicationUser user5 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484305",
            Name = "User5",
            Email = "user5@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user5.PasswordHash = passwordHasher.HashPassword(user5, "User*123");
        users.Add(user5);

        ApplicationUser user6 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484306",
            Name = "User6",
            Email = "user6@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user6.PasswordHash = passwordHasher.HashPassword(user6, "User*123");
        users.Add(user6);

        ApplicationUser user7 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484307",
            Name = "User7",
            Email = "user7@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user7.PasswordHash = passwordHasher.HashPassword(user7, "User*123");
        users.Add(user7);

        ApplicationUser user8 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484308",
            Name = "User8",
            Email = "user8@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user8.PasswordHash = passwordHasher.HashPassword(user8, "User*123");
        users.Add(user8);

        ApplicationUser user9 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484309",
            Name = "User9",
            Email = "user9@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user9.PasswordHash = passwordHasher.HashPassword(user9, "User*123");
        users.Add(user9);

        ApplicationUser user10 = new ApplicationUser()
        {
            Id = "b74ddd14-6340-4840-95c2-db1255484310",
            Name = "User9",
            Email = "user10@gmail.com",
            LockoutEnabled = false,
            PhoneNumber = "1234567890",
            DOB = DateTime.Now,
            Gender = "MALE",
            Avatar = "",
            Status = Status.ACTIVE,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        user10.PasswordHash = passwordHasher.HashPassword(user10, "User*123");
        users.Add(user10);

        builder.Entity<ApplicationUser>().HasData(users);
    }

    private void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09", Name = "ADMIN", ConcurrencyStamp = "1",
                NormalizedName = "ADMIN"
            },
            new IdentityRole()
            {
                Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "CUSTOMER", ConcurrencyStamp = "2",
                NormalizedName = "CUSTOMER"
            },
            new IdentityRole()
            {
                Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "ORGANIZER", ConcurrencyStamp = "3",
                NormalizedName = "ORGANIZER"
            }
        );
    }

    private void SeedUserRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityUserRole<string>>().HasData(
            new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db12554843e5", RoleId = "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484301", RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484302", RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484303", RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484304", RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484305", RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484306", RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484307", RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484308", RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "b74ddd14-6340-4840-95c2-db1255484309", RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330"
                },
                new IdentityUserRole<string>()
                    { UserId = "b74ddd14-6340-4840-95c2-db1255484310", RoleId = "fab4fac1-c546-41de-aebc-a14da6895711" }
            }
        );
    }
}