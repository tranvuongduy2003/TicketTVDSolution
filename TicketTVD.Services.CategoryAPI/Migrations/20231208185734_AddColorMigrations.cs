using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketTVD.Services.CategoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColorMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedAt", "UpdatedAt" },
                values: new object[] { "#264653", new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedAt", "UpdatedAt" },
                values: new object[] { "#2a9d8f", new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedAt", "UpdatedAt" },
                values: new object[] { "#e9c46a", new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(358), new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedAt", "UpdatedAt" },
                values: new object[] { "#f4a261", new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedAt", "UpdatedAt" },
                values: new object[] { "#e76f51", new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 12, 9, 1, 57, 34, 126, DateTimeKind.Local).AddTicks(362) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(695), new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 11, 3, 1, 14, 56, 208, DateTimeKind.Local).AddTicks(698) });
        }
    }
}
