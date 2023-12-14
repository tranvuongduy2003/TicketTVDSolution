using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketTVD.Services.TicketAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketDetailMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldQuantity",
                table: "TicketDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "SoldQuantity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TicketDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "SoldQuantity",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldQuantity",
                table: "TicketDetails");
        }
    }
}
