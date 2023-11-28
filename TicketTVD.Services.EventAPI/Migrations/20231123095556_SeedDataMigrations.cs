using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketTVD.Services.EventAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPromotion = table.Column<bool>(type: "bit", nullable: false),
                    PromotionPlan = table.Column<int>(type: "int", nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Favourite = table.Column<int>(type: "int", nullable: false),
                    Share = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "EventId", "Uri" },
                values: new object[,]
                {
                    { 1, 1, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 2, 1, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 3, 1, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 4, 1, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 5, 1, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 6, 2, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 7, 2, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 8, 2, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 9, 2, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 10, 2, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 11, 3, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 12, 3, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 13, 3, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 14, 3, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 15, 3, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 16, 4, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 17, 4, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 18, 4, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 19, 4, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 20, 4, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 21, 5, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 22, 5, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 23, 5, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 24, 5, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 25, 5, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 26, 6, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 27, 6, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 28, 6, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 29, 6, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 30, 6, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 31, 7, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 32, 7, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 33, 7, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 34, 7, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 35, 7, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 36, 8, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 37, 8, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 38, 8, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 39, 8, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 40, 8, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 41, 9, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 42, 9, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 43, 9, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 44, 9, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 45, 9, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 46, 10, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 47, 10, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 48, 10, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 49, 10, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 50, 10, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 51, 11, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 52, 11, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 53, 11, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 54, 11, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 55, 11, "http://dummyimage.com/119x100.png/ff4444/ffffff" },
                    { 56, 12, "http://dummyimage.com/189x100.png/5fa2dd/ffffff" },
                    { 57, 12, "http://dummyimage.com/169x100.png/dddddd/000000" },
                    { 58, 12, "http://dummyimage.com/183x100.png/ff4444/ffffff" },
                    { 59, 12, "http://dummyimage.com/106x100.png/cc0000/ffffff" },
                    { 60, 12, "http://dummyimage.com/119x100.png/ff4444/ffffff" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CategoryId", "CoverImage", "CreatedAt", "CreatorId", "Description", "EndTime", "EventDate", "Favourite", "IsPromotion", "Location", "Name", "PromotionPlan", "PublishTime", "Share", "StartTime", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "http://dummyimage.com/146x100.png/dddddd/000000", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7829), "b74ddd14-6340-4840-95c2-db1255484302", "Drainage of Cerebellum with Drainage Device, Open Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7817), new DateTime(2022, 12, 13, 12, 9, 52, 0, DateTimeKind.Local), 110, true, "Suite 97", "Viviana Ellingworth", 28, new DateTime(2024, 3, 22, 21, 56, 35, 0, DateTimeKind.Local), 279, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7805), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7830) },
                    { 2, 2, "http://dummyimage.com/212x100.png/5fa2dd/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7843), "b74ddd14-6340-4840-95c2-db1255484302", "Excision of Left Brachial Vein, Percutaneous Endoscopic Approach, Diagnostic", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7839), new DateTime(2023, 2, 23, 10, 24, 1, 0, DateTimeKind.Local), 113, false, "Room 1255", "Lucita Kite", 0, new DateTime(2024, 2, 11, 20, 55, 36, 0, DateTimeKind.Local), 287, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7838), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7844) },
                    { 3, 3, "http://dummyimage.com/183x100.png/ff4444/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7853), "b74ddd14-6340-4840-95c2-db1255484302", "Revision of Autologous Tissue Substitute in Chest Wall, External Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 2, 13, 2, 1, 46, 0, DateTimeKind.Local), 257, true, "Room 1341", "Edlin Doale", 76, new DateTime(2024, 1, 29, 9, 2, 34, 0, DateTimeKind.Local), 297, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7848), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7854) },
                    { 4, 4, "http://dummyimage.com/119x100.png/ff4444/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7863), "b74ddd14-6340-4840-95c2-db1255484302", "Extirpation of Matter from Common Bile Duct, Open Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 3, 25, 21, 47, 16, 0, DateTimeKind.Local), 8, false, "PO Box 21676", "Maitilde Finlason", 0, new DateTime(2024, 9, 7, 20, 49, 20, 0, DateTimeKind.Local), 111, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7858), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7863) },
                    { 5, 5, "http://dummyimage.com/106x100.png/cc0000/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7873), "b74ddd14-6340-4840-95c2-db1255484302", "Dilation of Left External Iliac Artery, Bifurcation, Percutaneous Endoscopic Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 1, 16, 17, 17, 12, 0, DateTimeKind.Local), 35, true, "Suite 54", "Elisabet Pasmore", 93, new DateTime(2024, 1, 6, 7, 22, 49, 0, DateTimeKind.Local), 124, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7868), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7873) },
                    { 6, 1, "http://dummyimage.com/169x100.png/dddddd/000000", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7882), "b74ddd14-6340-4840-95c2-db1255484302", "Immobilization of Right Lower Leg using Brace", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 5, 7, 16, 36, 28, 0, DateTimeKind.Local), 273, false, "PO Box 57974", "Nicolai Pinor", 0, new DateTime(2024, 1, 18, 14, 55, 19, 0, DateTimeKind.Local), 124, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7878), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7883) },
                    { 7, 2, "http://dummyimage.com/180x100.png/5fa2dd/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7892), "b74ddd14-6340-4840-95c2-db1255484302", "Dilation of Upper Artery with Drug-eluting Intraluminal Device, Percutaneous Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7888), new DateTime(2022, 12, 6, 11, 4, 2, 0, DateTimeKind.Local), 261, false, "11th Floor", "Jorgan Donaghy", 91, new DateTime(2024, 2, 21, 10, 2, 23, 0, DateTimeKind.Local), 10, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7888), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7892) },
                    { 8, 3, "http://dummyimage.com/244x100.png/cc0000/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7900), "b74ddd14-6340-4840-95c2-db1255484302", "Destruction of Right Shoulder Muscle, Open Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 1, 10, 3, 21, 3, 0, DateTimeKind.Local), 16, false, "Room 1646", "Sonya Goddert", 0, new DateTime(2023, 11, 26, 1, 32, 36, 0, DateTimeKind.Local), 66, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7896), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7901) },
                    { 9, 4, "http://dummyimage.com/154x100.png/5fa2dd/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7910), "b74ddd14-6340-4840-95c2-db1255484302", "Bypass Cecum to Cutaneous with Nonautologous Tissue Substitute, Via Natural or Artificial Opening Endoscopic", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 6, 21, 23, 29, 58, 0, DateTimeKind.Local), 6, true, "Room 209", "Simone Noblett", 69, new DateTime(2024, 9, 15, 1, 50, 13, 0, DateTimeKind.Local), 113, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7905), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7910) },
                    { 10, 5, "http://dummyimage.com/111x100.png/ff4444/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7918), "b74ddd14-6340-4840-95c2-db1255484302", "Excision of Greater Omentum, Percutaneous Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 5, 30, 18, 15, 6, 0, DateTimeKind.Local), 186, false, "11th Floor", "Myrilla De Bruin", 0, new DateTime(2024, 7, 7, 5, 37, 26, 0, DateTimeKind.Local), 193, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7914), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7919) },
                    { 11, 1, "http://dummyimage.com/148x100.png/5fa2dd/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8001), "b74ddd14-6340-4840-95c2-db1255484302", "Supplement Left Foot Vein with Nonautologous Tissue Substitute, Open Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 8, 2, 17, 0, 3, 0, DateTimeKind.Local), 287, true, "1st Floor", "Isobel McIlroy", 81, new DateTime(2023, 12, 2, 10, 42, 57, 0, DateTimeKind.Local), 193, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(7996), 0, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8002) },
                    { 12, 2, "http://dummyimage.com/213x100.png/5fa2dd/ffffff", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8012), "b74ddd14-6340-4840-95c2-db1255484302", "Resection of Perineum Tendon, Open Approach", new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 1, 10, 20, 2, 29, 0, DateTimeKind.Local), 146, true, "PO Box 86135", "Bradly Majury", 95, new DateTime(2023, 12, 15, 12, 37, 54, 0, DateTimeKind.Local), 217, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8007), 1, new DateTime(2023, 11, 23, 16, 55, 55, 935, DateTimeKind.Local).AddTicks(8012) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
