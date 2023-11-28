using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketTVD.Services.CategoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(677), "Âm nhạc", new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(691) },
                    { 2, new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(693), "Thể thao", new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(693) },
                    { 3, new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(695), "Hội họa", new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(695) },
                    { 4, new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(696), "Doanh nghệp", new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(697) },
                    { 5, new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(698), "Nhiếp ảnh", new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(698) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
