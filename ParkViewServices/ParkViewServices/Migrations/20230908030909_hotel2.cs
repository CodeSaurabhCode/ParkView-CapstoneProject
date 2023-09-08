using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkViewServices.Migrations
{
    public partial class hotel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 41, 1, 2, "Presidential Suite 101", 101, 4, false },
                    { 42, 1, 2, "Presidential Suite 102", 102, 4, false },
                    { 43, 1, 2, "Presidential Suite 103", 103, 4, false },
                    { 44, 1, 2, "Presidential Suite 104", 104, 4, false },
                    { 45, 1, 2, "Presidential Suite 105", 105, 4, false },
                    { 46, 1, 2, "Executive Suite 201", 201, 3, false },
                    { 47, 1, 2, "Executive Suite 202", 202, 3, false },
                    { 48, 1, 2, "Executive Suite 203", 203, 3, false },
                    { 49, 1, 2, "Executive Suite 204", 204, 3, false },
                    { 50, 1, 2, "Executive Suite 205", 205, 3, false },
                    { 51, 1, 2, "Executive Suite 206", 206, 3, false },
                    { 52, 1, 2, "Executive Suite 207", 207, 3, false },
                    { 53, 1, 2, "Executive Suite 208", 208, 3, false },
                    { 54, 1, 2, "Executive Suite 209", 209, 3, false },
                    { 55, 1, 2, "Executive Suite 210", 210, 3, false },
                    { 56, 2, 2, "Deluxe Room 301", 301, 1, false },
                    { 57, 2, 2, "Deluxe Room 302", 302, 1, false },
                    { 58, 2, 2, "Deluxe Room 303", 303, 1, false },
                    { 59, 2, 2, "Deluxe Room 304", 304, 1, false },
                    { 60, 2, 2, "Deluxe Room 305", 305, 1, false },
                    { 61, 2, 2, "Deluxe Room 306", 306, 1, false },
                    { 62, 2, 2, "Deluxe Room 307", 307, 1, false },
                    { 63, 2, 2, "Deluxe Room 308", 308, 1, false },
                    { 64, 2, 2, "Deluxe Room 309", 309, 1, false },
                    { 65, 2, 2, "Deluxe Room 310", 310, 1, false },
                    { 66, 2, 2, "Deluxe Room 311", 311, 1, false },
                    { 67, 2, 2, "Deluxe Room 312", 312, 1, false },
                    { 68, 2, 2, "Deluxe Room 313", 313, 1, false },
                    { 69, 2, 2, "Deluxe Room 314", 314, 1, false },
                    { 70, 2, 2, "Deluxe Room 315", 315, 1, false },
                    { 71, 2, 2, "Super Deluxe Room 401", 401, 2, false },
                    { 72, 2, 2, "Super Deluxe Room 402", 402, 2, false },
                    { 73, 2, 2, "Super Deluxe Room 403", 403, 2, false },
                    { 74, 2, 2, "Super Deluxe Room 404", 404, 2, false },
                    { 75, 2, 2, "Super Deluxe Room 405", 405, 2, false },
                    { 76, 2, 2, "Super Deluxe Room 406", 406, 2, false },
                    { 77, 2, 2, "Super Deluxe Room 407", 407, 2, false },
                    { 78, 2, 2, "Super Deluxe Room 408", 408, 2, false },
                    { 79, 2, 2, "Super Deluxe Room 409", 409, 2, false },
                    { 80, 2, 2, "Super Deluxe Room 410", 410, 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80);
        }
    }
}
