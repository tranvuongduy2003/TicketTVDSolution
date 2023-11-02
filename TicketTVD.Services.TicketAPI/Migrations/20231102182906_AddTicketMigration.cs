using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketTVD.Services.TicketAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketDetailId = table.Column<int>(type: "int", nullable: false),
                    TicketCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_TicketDetails_TicketDetailsId",
                        column: x => x.TicketDetailsId,
                        principalTable: "TicketDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TicketDetails",
                columns: new[] { "Id", "CloseTime", "EventId", "IsPaid", "Price", "Quantity", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 20, 19, 23, 30, 0, DateTimeKind.Local), 1, false, 0m, 161, new DateTime(2022, 12, 13, 12, 9, 52, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2023, 7, 29, 1, 42, 35, 0, DateTimeKind.Local), 2, false, 0m, 79, new DateTime(2023, 2, 23, 10, 24, 1, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2023, 8, 14, 9, 28, 45, 0, DateTimeKind.Local), 3, true, 4221000m, 103, new DateTime(2023, 2, 13, 2, 1, 46, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2023, 5, 14, 8, 10, 46, 0, DateTimeKind.Local), 4, false, 0m, 30, new DateTime(2023, 3, 25, 21, 47, 16, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2023, 5, 27, 17, 21, 44, 0, DateTimeKind.Local), 5, true, 4684000m, 13, new DateTime(2023, 1, 16, 17, 17, 12, 0, DateTimeKind.Local) },
                    { 6, new DateTime(2023, 5, 16, 0, 12, 2, 0, DateTimeKind.Local), 6, true, 8166000m, 61, new DateTime(2023, 5, 7, 16, 36, 28, 0, DateTimeKind.Local) },
                    { 7, new DateTime(2023, 7, 18, 13, 7, 55, 0, DateTimeKind.Local), 7, false, 0m, 196, new DateTime(2022, 12, 6, 11, 4, 2, 0, DateTimeKind.Local) },
                    { 8, new DateTime(2023, 8, 20, 22, 51, 14, 0, DateTimeKind.Local), 8, false, 0m, 51, new DateTime(2023, 1, 10, 3, 21, 3, 0, DateTimeKind.Local) },
                    { 9, new DateTime(2023, 8, 16, 14, 51, 26, 0, DateTimeKind.Local), 9, false, 0m, 8, new DateTime(2023, 6, 21, 23, 29, 58, 0, DateTimeKind.Local) },
                    { 10, new DateTime(2023, 10, 27, 19, 37, 21, 0, DateTimeKind.Local), 10, false, 0m, 20, new DateTime(2023, 5, 30, 18, 15, 6, 0, DateTimeKind.Local) },
                    { 11, new DateTime(2023, 8, 22, 4, 27, 24, 0, DateTimeKind.Local), 11, false, 0m, 130, new DateTime(2023, 8, 2, 17, 0, 3, 0, DateTimeKind.Local) },
                    { 12, new DateTime(2023, 1, 28, 1, 21, 17, 0, DateTimeKind.Local), 12, true, 9620000m, 15, new DateTime(2023, 1, 10, 20, 2, 29, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketDetailsId",
                table: "Tickets",
                column: "TicketDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TicketDetails");
        }
    }
}
