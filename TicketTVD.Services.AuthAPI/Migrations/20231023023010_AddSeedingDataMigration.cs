using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketTVD.Services.AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<int>(type: "int", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09", "1", "ADMIN", "ADMIN" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "CUSTOMER", "CUSTOMER" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "3", "ORGANIZER", "ORGANIZER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "CreatedAt", "DOB", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Provider", "RefreshToken", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "b74ddd14-6340-4840-95c2-db1255484301", 0, "", "f2653fdb-fe9c-4ec1-8517-5a96fba157c1", new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1573), "user1@gmail.com", false, "MALE", false, null, "User1", null, null, "AQAAAAIAAYagAAAAELe2nA29s2P1ooozDVM4XYQ4ASI3gBU+Hyq0kcp7KwflnH8MVB8I/ZarGvc6ZFC39w==", "1234567890", false, null, null, "b74dbf49-e3ce-4d84-871c-631646829be1", 0, false, new DateTime(2023, 10, 23, 9, 30, 8, 526, DateTimeKind.Local).AddTicks(1615), null },
                    { "b74ddd14-6340-4840-95c2-db1255484302", 0, "", "9e231724-48dc-4abe-a8a9-d01e58977e3c", new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8289), "user2@gmail.com", false, "MALE", false, null, "User2", null, null, "AQAAAAIAAYagAAAAEE18GX1NxmcfnDKCkLPoaf8WXOazfOgeNyNHrfSQbNskLHVq69yHi6/d9xU4TAn1nQ==", "1234567890", false, null, null, "62878b71-0541-4bac-bfd4-0a71b40cb177", 0, false, new DateTime(2023, 10, 23, 9, 30, 8, 656, DateTimeKind.Local).AddTicks(8321), null },
                    { "b74ddd14-6340-4840-95c2-db1255484303", 0, "", "6f68b494-836c-45ba-b560-a530e7e756ec", new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5655), "user3@gmail.com", false, "MALE", false, null, "User3", null, null, "AQAAAAIAAYagAAAAEJ4kZsc38uI5SW7kLQTBytQUiaIak3elCbV9iYy4sXXSS2pnS6jgzLRkPtckdGgm+w==", "1234567890", false, null, null, "120146bb-0bdf-40ba-a616-1a22eae29167", 0, false, new DateTime(2023, 10, 23, 9, 30, 8, 787, DateTimeKind.Local).AddTicks(5696), null },
                    { "b74ddd14-6340-4840-95c2-db1255484304", 0, "", "5a8910a7-0fa6-4d0f-aa77-45f9cfe07547", new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(7978), "user4@gmail.com", false, "MALE", false, null, "User4", null, null, "AQAAAAIAAYagAAAAEK/da/hkSDwbHNK/onsfSHNyUUqUt5LUyWTastRL5ooPpCuK5NTIVtIu1v09MQVFAg==", "1234567890", false, null, null, "88f7e75a-973b-437a-8e05-fba171042184", 0, false, new DateTime(2023, 10, 23, 9, 30, 8, 924, DateTimeKind.Local).AddTicks(8008), null },
                    { "b74ddd14-6340-4840-95c2-db1255484305", 0, "", "04d2687d-0839-4103-b4fc-c8856218991c", new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4318), "user5@gmail.com", false, "MALE", false, null, "User5", null, null, "AQAAAAIAAYagAAAAEFSYMNNDrNSM1lQNt/1qPj0/mmtCozcnB2UrmBqj1/YVnYprFeUOWHpRMcYHMUim0w==", "1234567890", false, null, null, "a1e51eb8-4c0d-4940-9836-b3446a172190", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 59, DateTimeKind.Local).AddTicks(4352), null },
                    { "b74ddd14-6340-4840-95c2-db1255484306", 0, "", "8e943618-d092-4215-92ba-51d4cc958c08", new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5356), new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5328), "user6@gmail.com", false, "MALE", false, null, "User6", null, null, "AQAAAAIAAYagAAAAEFePFM1Z2KAWyYDlw2djJ5zI4AumKyCbgNoqoHuDC460r6I4xUMb52QoXmvxhqOdKg==", "1234567890", false, null, null, "40e89551-661c-4b8e-8ef8-b22b7c13841f", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 187, DateTimeKind.Local).AddTicks(5357), null },
                    { "b74ddd14-6340-4840-95c2-db1255484307", 0, "", "51d10e16-9e6a-4a2c-bf55-907287297e72", new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3000), "user7@gmail.com", false, "MALE", false, null, "User7", null, null, "AQAAAAIAAYagAAAAEPnTNEa9Je9KM2tmtsKNga1IzNMoLz2ZD3v3lirw9/NwFiK3891i+bSyZAMBkruV+A==", "1234567890", false, null, null, "43be6f0b-8642-4559-9673-313e49b7615b", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 312, DateTimeKind.Local).AddTicks(3028), null },
                    { "b74ddd14-6340-4840-95c2-db1255484308", 0, "", "6f1e7290-71dc-4815-8604-a0115296f4bb", new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9795), "user8@gmail.com", false, "MALE", false, null, "User8", null, null, "AQAAAAIAAYagAAAAEBAPAQhRmeza1G6EjCVaeOSmokt1LU7+LOkYb7xAW65NWlAR6JRjzKUvqkvfAJ+tXg==", "1234567890", false, null, null, "4a141d40-6b56-403e-89ac-34f418c0bb5a", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 444, DateTimeKind.Local).AddTicks(9812), null },
                    { "b74ddd14-6340-4840-95c2-db1255484309", 0, "", "a1fa143f-f8b3-4d1e-9db2-bca90671da3c", new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1035), "user9@gmail.com", false, "MALE", false, null, "User9", null, null, "AQAAAAIAAYagAAAAEE4+oz47LUyiqkbeK1zkwbKJUtOdcbB3ImbzBlZCCUbb/nZFR5tYMjB0xoQ/WzwEOA==", "1234567890", false, null, null, "e78ec82a-d4d1-440d-8a0d-abc09fae9b84", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 579, DateTimeKind.Local).AddTicks(1054), null },
                    { "b74ddd14-6340-4840-95c2-db1255484310", 0, "", "e2be757f-e3cb-4e27-b6a6-685675e1cd9c", new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2966), "user10@gmail.com", false, "MALE", false, null, "User9", null, null, "AQAAAAIAAYagAAAAEAaJHfwcDZGJZ5DDYxoq7qHPYmTd9E97daVmRUvNY3ipmCOtSpS4wogTX8g/rzWeXw==", "1234567890", false, null, null, "3e4c04e5-fdf5-4c20-9f9b-3eed10ea7e3a", 0, false, new DateTime(2023, 10, 23, 9, 30, 9, 703, DateTimeKind.Local).AddTicks(2982), null },
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "", "4a5cfc22-0b23-4e2c-99d5-85731448fea1", new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5836), "admin@gmail.com", false, "MALE", false, null, "Admin", null, null, "AQAAAAIAAYagAAAAEM9R5ZTDtHd3xlf4yi8MzL5QS88Gc4s/2aK/zmmZbERhnFAEfCtreULg94NMtUj82g==", "1234567890", false, null, null, "7ffc5bae-dc96-4023-aabf-04ee9cff895c", 0, false, new DateTime(2023, 10, 23, 9, 30, 8, 400, DateTimeKind.Local).AddTicks(5870), null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-db1255484301" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db1255484302" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-db1255484303" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db1255484304" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-db1255484305" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db1255484306" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-db1255484307" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db1255484308" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "b74ddd14-6340-4840-95c2-db1255484309" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db1255484310" },
                    { "486b42e2-fee6-4ea4-8b98-f4dfbf1c9a09", "b74ddd14-6340-4840-95c2-db12554843e5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
