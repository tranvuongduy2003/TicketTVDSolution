using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketTVD.Services.EventAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5948), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5956), new DateTime(2023, 11, 21, 11, 4, 44, 526, DateTimeKind.Local).AddTicks(5957) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(126), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(164), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(181), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 11, 3, 3, 31, 10, 21, DateTimeKind.Local).AddTicks(214) });
        }
    }
}
