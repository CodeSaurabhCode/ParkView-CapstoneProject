using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkViewServices.Migrations
{
    public partial class hotel10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 81, 1, 3, "Presidential Suite 101", 101, 4, false },
                    { 82, 1, 3, "Presidential Suite 102", 102, 4, false },
                    { 83, 1, 3, "Presidential Suite 103", 103, 4, false },
                    { 84, 1, 3, "Presidential Suite 104", 104, 4, false },
                    { 85, 1, 3, "Presidential Suite 105", 105, 4, false },
                    { 86, 1, 3, "Executive Suite 201", 201, 3, false },
                    { 87, 1, 3, "Executive Suite 202", 202, 3, false },
                    { 88, 1, 3, "Executive Suite 203", 203, 3, false },
                    { 89, 1, 3, "Executive Suite 204", 204, 3, false },
                    { 90, 1, 3, "Executive Suite 205", 205, 3, false },
                    { 91, 1, 3, "Executive Suite 206", 206, 3, false },
                    { 92, 1, 3, "Executive Suite 207", 207, 3, false },
                    { 93, 1, 3, "Executive Suite 208", 208, 3, false },
                    { 94, 1, 3, "Executive Suite 209", 209, 3, false },
                    { 95, 1, 3, "Executive Suite 210", 210, 3, false },
                    { 96, 2, 3, "Deluxe Room 301", 301, 1, false },
                    { 97, 2, 3, "Deluxe Room 302", 302, 1, false },
                    { 98, 2, 3, "Deluxe Room 303", 303, 1, false },
                    { 99, 2, 3, "Deluxe Room 304", 304, 1, false },
                    { 100, 2, 3, "Deluxe Room 305", 305, 1, false },
                    { 101, 2, 3, "Deluxe Room 306", 306, 1, false },
                    { 102, 2, 3, "Deluxe Room 307", 307, 1, false },
                    { 103, 2, 3, "Deluxe Room 308", 308, 1, false },
                    { 104, 2, 3, "Deluxe Room 309", 309, 1, false },
                    { 105, 2, 3, "Deluxe Room 310", 310, 1, false },
                    { 106, 2, 3, "Deluxe Room 311", 311, 1, false },
                    { 107, 2, 3, "Deluxe Room 312", 312, 1, false },
                    { 108, 2, 3, "Deluxe Room 313", 313, 1, false },
                    { 109, 2, 3, "Deluxe Room 314", 314, 1, false },
                    { 110, 2, 3, "Deluxe Room 315", 315, 1, false },
                    { 111, 2, 3, "Super Deluxe Room 401", 401, 2, false },
                    { 112, 2, 3, "Super Deluxe Room 402", 402, 2, false },
                    { 113, 2, 3, "Super Deluxe Room 403", 403, 2, false },
                    { 114, 2, 3, "Super Deluxe Room 404", 404, 2, false },
                    { 115, 2, 3, "Super Deluxe Room 405", 405, 2, false },
                    { 116, 2, 3, "Super Deluxe Room 406", 406, 2, false },
                    { 117, 2, 3, "Super Deluxe Room 407", 407, 2, false },
                    { 118, 2, 3, "Super Deluxe Room 408", 408, 2, false },
                    { 119, 2, 3, "Super Deluxe Room 409", 409, 2, false },
                    { 120, 2, 3, "Super Deluxe Room 410", 410, 2, false },
                    { 121, 1, 4, "Presidential Suite 101", 101, 4, false },
                    { 122, 1, 4, "Presidential Suite 102", 102, 4, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 123, 1, 4, "Presidential Suite 103", 103, 4, false },
                    { 124, 1, 4, "Presidential Suite 104", 104, 4, false },
                    { 125, 1, 4, "Presidential Suite 105", 105, 4, false },
                    { 126, 1, 4, "Executive Suite 201", 201, 3, false },
                    { 127, 1, 4, "Executive Suite 202", 202, 3, false },
                    { 128, 1, 4, "Executive Suite 203", 203, 3, false },
                    { 129, 1, 4, "Executive Suite 204", 204, 3, false },
                    { 130, 1, 4, "Executive Suite 205", 205, 3, false },
                    { 131, 1, 4, "Executive Suite 206", 206, 3, false },
                    { 132, 1, 4, "Executive Suite 207", 207, 3, false },
                    { 133, 1, 4, "Executive Suite 208", 208, 3, false },
                    { 134, 1, 4, "Executive Suite 209", 209, 3, false },
                    { 135, 1, 4, "Executive Suite 210", 210, 3, false },
                    { 136, 2, 4, "Deluxe Room 301", 301, 1, false },
                    { 137, 2, 4, "Deluxe Room 302", 302, 1, false },
                    { 138, 2, 4, "Deluxe Room 303", 303, 1, false },
                    { 139, 2, 4, "Deluxe Room 304", 304, 1, false },
                    { 140, 2, 4, "Deluxe Room 305", 305, 1, false },
                    { 141, 2, 4, "Deluxe Room 306", 306, 1, false },
                    { 142, 2, 4, "Deluxe Room 307", 307, 1, false },
                    { 143, 2, 4, "Deluxe Room 308", 308, 1, false },
                    { 144, 2, 4, "Deluxe Room 309", 309, 1, false },
                    { 145, 2, 4, "Deluxe Room 310", 310, 1, false },
                    { 146, 2, 4, "Deluxe Room 311", 311, 1, false },
                    { 147, 2, 4, "Deluxe Room 312", 312, 1, false },
                    { 148, 2, 4, "Deluxe Room 313", 313, 1, false },
                    { 149, 2, 4, "Deluxe Room 314", 314, 1, false },
                    { 150, 2, 4, "Deluxe Room 315", 315, 1, false },
                    { 151, 2, 4, "Super Deluxe Room 401", 401, 2, false },
                    { 152, 2, 4, "Super Deluxe Room 402", 402, 2, false },
                    { 153, 2, 4, "Super Deluxe Room 403", 403, 2, false },
                    { 154, 2, 4, "Super Deluxe Room 404", 404, 2, false },
                    { 155, 2, 4, "Super Deluxe Room 405", 405, 2, false },
                    { 156, 2, 4, "Super Deluxe Room 406", 406, 2, false },
                    { 157, 2, 4, "Super Deluxe Room 407", 407, 2, false },
                    { 158, 2, 4, "Super Deluxe Room 408", 408, 2, false },
                    { 159, 2, 4, "Super Deluxe Room 409", 409, 2, false },
                    { 160, 2, 4, "Super Deluxe Room 410", 410, 2, false },
                    { 161, 1, 5, "Presidential Suite 101", 101, 4, false },
                    { 162, 1, 5, "Presidential Suite 102", 102, 4, false },
                    { 163, 1, 5, "Presidential Suite 103", 103, 4, false },
                    { 164, 1, 5, "Presidential Suite 104", 104, 4, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 165, 1, 5, "Presidential Suite 105", 105, 4, false },
                    { 166, 1, 5, "Executive Suite 201", 201, 3, false },
                    { 167, 1, 5, "Executive Suite 202", 202, 3, false },
                    { 168, 1, 5, "Executive Suite 203", 203, 3, false },
                    { 169, 1, 5, "Executive Suite 204", 204, 3, false },
                    { 170, 1, 5, "Executive Suite 205", 205, 3, false },
                    { 171, 1, 5, "Executive Suite 206", 206, 3, false },
                    { 172, 1, 5, "Executive Suite 207", 207, 3, false },
                    { 173, 1, 5, "Executive Suite 208", 208, 3, false },
                    { 174, 1, 5, "Executive Suite 209", 209, 3, false },
                    { 175, 1, 5, "Executive Suite 210", 210, 3, false },
                    { 176, 2, 5, "Deluxe Room 301", 301, 1, false },
                    { 177, 2, 5, "Deluxe Room 302", 302, 1, false },
                    { 178, 2, 5, "Deluxe Room 303", 303, 1, false },
                    { 179, 2, 5, "Deluxe Room 304", 304, 1, false },
                    { 180, 2, 5, "Deluxe Room 305", 305, 1, false },
                    { 181, 2, 5, "Deluxe Room 306", 306, 1, false },
                    { 182, 2, 5, "Deluxe Room 307", 307, 1, false },
                    { 183, 2, 5, "Deluxe Room 308", 308, 1, false },
                    { 184, 2, 5, "Deluxe Room 309", 309, 1, false },
                    { 185, 2, 5, "Deluxe Room 310", 310, 1, false },
                    { 186, 2, 5, "Deluxe Room 311", 311, 1, false },
                    { 187, 2, 5, "Deluxe Room 312", 312, 1, false },
                    { 188, 2, 5, "Deluxe Room 313", 313, 1, false },
                    { 189, 2, 5, "Deluxe Room 314", 314, 1, false },
                    { 190, 2, 5, "Deluxe Room 315", 315, 1, false },
                    { 191, 2, 5, "Super Deluxe Room 401", 401, 2, false },
                    { 192, 2, 5, "Super Deluxe Room 402", 402, 2, false },
                    { 193, 2, 5, "Super Deluxe Room 403", 403, 2, false },
                    { 194, 2, 5, "Super Deluxe Room 404", 404, 2, false },
                    { 195, 2, 5, "Super Deluxe Room 405", 405, 2, false },
                    { 196, 2, 5, "Super Deluxe Room 406", 406, 2, false },
                    { 197, 2, 5, "Super Deluxe Room 407", 407, 2, false },
                    { 198, 2, 5, "Super Deluxe Room 408", 408, 2, false },
                    { 199, 2, 5, "Super Deluxe Room 409", 409, 2, false },
                    { 200, 2, 5, "Super Deluxe Room 410", 410, 2, false },
                    { 201, 1, 6, "Presidential Suite 101", 101, 4, false },
                    { 202, 1, 6, "Presidential Suite 102", 102, 4, false },
                    { 203, 1, 6, "Presidential Suite 103", 103, 4, false },
                    { 204, 1, 6, "Presidential Suite 104", 104, 4, false },
                    { 205, 1, 6, "Presidential Suite 105", 105, 4, false },
                    { 206, 1, 6, "Executive Suite 201", 201, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 207, 1, 6, "Executive Suite 202", 202, 3, false },
                    { 208, 1, 6, "Executive Suite 203", 203, 3, false },
                    { 209, 1, 6, "Executive Suite 204", 204, 3, false },
                    { 210, 1, 6, "Executive Suite 205", 205, 3, false },
                    { 211, 1, 6, "Executive Suite 206", 206, 3, false },
                    { 212, 1, 6, "Executive Suite 207", 207, 3, false },
                    { 213, 1, 6, "Executive Suite 208", 208, 3, false },
                    { 214, 1, 6, "Executive Suite 209", 209, 3, false },
                    { 215, 1, 6, "Executive Suite 210", 210, 3, false },
                    { 216, 2, 6, "Deluxe Room 301", 301, 1, false },
                    { 217, 2, 6, "Deluxe Room 302", 302, 1, false },
                    { 218, 2, 6, "Deluxe Room 303", 303, 1, false },
                    { 219, 2, 6, "Deluxe Room 304", 304, 1, false },
                    { 220, 2, 6, "Deluxe Room 305", 305, 1, false },
                    { 221, 2, 6, "Deluxe Room 306", 306, 1, false },
                    { 222, 2, 6, "Deluxe Room 307", 307, 1, false },
                    { 223, 2, 6, "Deluxe Room 308", 308, 1, false },
                    { 224, 2, 6, "Deluxe Room 309", 309, 1, false },
                    { 225, 2, 6, "Deluxe Room 310", 310, 1, false },
                    { 226, 2, 6, "Deluxe Room 311", 311, 1, false },
                    { 227, 2, 6, "Deluxe Room 312", 312, 1, false },
                    { 228, 2, 6, "Deluxe Room 313", 313, 1, false },
                    { 229, 2, 6, "Deluxe Room 314", 314, 1, false },
                    { 230, 2, 6, "Deluxe Room 315", 315, 1, false },
                    { 231, 2, 6, "Super Deluxe Room 401", 401, 2, false },
                    { 232, 2, 6, "Super Deluxe Room 402", 402, 2, false },
                    { 233, 2, 6, "Super Deluxe Room 403", 403, 2, false },
                    { 234, 2, 6, "Super Deluxe Room 404", 404, 2, false },
                    { 235, 2, 6, "Super Deluxe Room 405", 405, 2, false },
                    { 236, 2, 6, "Super Deluxe Room 406", 406, 2, false },
                    { 237, 2, 6, "Super Deluxe Room 407", 407, 2, false },
                    { 238, 2, 6, "Super Deluxe Room 408", 408, 2, false },
                    { 239, 2, 6, "Super Deluxe Room 409", 409, 2, false },
                    { 240, 2, 6, "Super Deluxe Room 410", 410, 2, false },
                    { 241, 1, 7, "Presidential Suite 101", 101, 4, false },
                    { 242, 1, 7, "Presidential Suite 102", 102, 4, false },
                    { 243, 1, 7, "Presidential Suite 103", 103, 4, false },
                    { 244, 1, 7, "Presidential Suite 104", 104, 4, false },
                    { 245, 1, 7, "Presidential Suite 105", 105, 4, false },
                    { 246, 1, 7, "Executive Suite 201", 201, 3, false },
                    { 247, 1, 7, "Executive Suite 202", 202, 3, false },
                    { 248, 1, 7, "Executive Suite 203", 203, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 249, 1, 7, "Executive Suite 204", 204, 3, false },
                    { 250, 1, 7, "Executive Suite 205", 205, 3, false },
                    { 251, 1, 7, "Executive Suite 206", 206, 3, false },
                    { 252, 1, 7, "Executive Suite 207", 207, 3, false },
                    { 253, 1, 7, "Executive Suite 208", 208, 3, false },
                    { 254, 1, 7, "Executive Suite 209", 209, 3, false },
                    { 255, 1, 7, "Executive Suite 210", 210, 3, false },
                    { 256, 2, 7, "Deluxe Room 301", 301, 1, false },
                    { 257, 2, 7, "Deluxe Room 302", 302, 1, false },
                    { 258, 2, 7, "Deluxe Room 303", 303, 1, false },
                    { 259, 2, 7, "Deluxe Room 304", 304, 1, false },
                    { 260, 2, 7, "Deluxe Room 305", 305, 1, false },
                    { 261, 2, 7, "Deluxe Room 306", 306, 1, false },
                    { 262, 2, 7, "Deluxe Room 307", 307, 1, false },
                    { 263, 2, 7, "Deluxe Room 308", 308, 1, false },
                    { 264, 2, 7, "Deluxe Room 309", 309, 1, false },
                    { 265, 2, 7, "Deluxe Room 310", 310, 1, false },
                    { 266, 2, 7, "Deluxe Room 311", 311, 1, false },
                    { 267, 2, 7, "Deluxe Room 312", 312, 1, false },
                    { 268, 2, 7, "Deluxe Room 313", 313, 1, false },
                    { 269, 2, 7, "Deluxe Room 314", 314, 1, false },
                    { 270, 2, 7, "Deluxe Room 315", 315, 1, false },
                    { 271, 2, 7, "Super Deluxe Room 401", 401, 2, false },
                    { 272, 2, 7, "Super Deluxe Room 402", 402, 2, false },
                    { 273, 2, 7, "Super Deluxe Room 403", 403, 2, false },
                    { 274, 2, 7, "Super Deluxe Room 404", 404, 2, false },
                    { 275, 2, 7, "Super Deluxe Room 405", 405, 2, false },
                    { 276, 2, 7, "Super Deluxe Room 406", 406, 2, false },
                    { 277, 2, 7, "Super Deluxe Room 407", 407, 2, false },
                    { 278, 2, 7, "Super Deluxe Room 408", 408, 2, false },
                    { 279, 2, 7, "Super Deluxe Room 409", 409, 2, false },
                    { 280, 2, 7, "Super Deluxe Room 410", 410, 2, false },
                    { 281, 1, 8, "Presidential Suite 101", 101, 4, false },
                    { 282, 1, 8, "Presidential Suite 102", 102, 4, false },
                    { 283, 1, 8, "Presidential Suite 103", 103, 4, false },
                    { 284, 1, 8, "Presidential Suite 104", 104, 4, false },
                    { 285, 1, 8, "Presidential Suite 105", 105, 4, false },
                    { 286, 1, 8, "Executive Suite 201", 201, 3, false },
                    { 287, 1, 8, "Executive Suite 202", 202, 3, false },
                    { 288, 1, 8, "Executive Suite 203", 203, 3, false },
                    { 289, 1, 8, "Executive Suite 204", 204, 3, false },
                    { 290, 1, 8, "Executive Suite 205", 205, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 291, 1, 8, "Executive Suite 206", 206, 3, false },
                    { 292, 1, 8, "Executive Suite 207", 207, 3, false },
                    { 293, 1, 8, "Executive Suite 208", 208, 3, false },
                    { 294, 1, 8, "Executive Suite 209", 209, 3, false },
                    { 295, 1, 8, "Executive Suite 210", 210, 3, false },
                    { 296, 2, 8, "Deluxe Room 301", 301, 1, false },
                    { 297, 2, 8, "Deluxe Room 302", 302, 1, false },
                    { 298, 2, 8, "Deluxe Room 303", 303, 1, false },
                    { 299, 2, 8, "Deluxe Room 304", 304, 1, false },
                    { 300, 2, 8, "Deluxe Room 305", 305, 1, false },
                    { 301, 2, 8, "Deluxe Room 306", 306, 1, false },
                    { 302, 2, 8, "Deluxe Room 307", 307, 1, false },
                    { 303, 2, 8, "Deluxe Room 308", 308, 1, false },
                    { 304, 2, 8, "Deluxe Room 309", 309, 1, false },
                    { 305, 2, 8, "Deluxe Room 310", 310, 1, false },
                    { 306, 2, 8, "Deluxe Room 311", 311, 1, false },
                    { 307, 2, 8, "Deluxe Room 312", 312, 1, false },
                    { 308, 2, 8, "Deluxe Room 313", 313, 1, false },
                    { 309, 2, 8, "Deluxe Room 314", 314, 1, false },
                    { 310, 2, 8, "Deluxe Room 315", 315, 1, false },
                    { 311, 2, 8, "Super Deluxe Room 401", 401, 2, false },
                    { 312, 2, 8, "Super Deluxe Room 402", 402, 2, false },
                    { 313, 2, 8, "Super Deluxe Room 403", 403, 2, false },
                    { 314, 2, 8, "Super Deluxe Room 404", 404, 2, false },
                    { 315, 2, 8, "Super Deluxe Room 405", 405, 2, false },
                    { 316, 2, 8, "Super Deluxe Room 406", 406, 2, false },
                    { 317, 2, 8, "Super Deluxe Room 407", 407, 2, false },
                    { 318, 2, 8, "Super Deluxe Room 408", 408, 2, false },
                    { 319, 2, 8, "Super Deluxe Room 409", 409, 2, false },
                    { 320, 2, 8, "Super Deluxe Room 410", 410, 2, false },
                    { 321, 1, 9, "Presidential Suite 101", 101, 4, false },
                    { 322, 1, 9, "Presidential Suite 102", 102, 4, false },
                    { 323, 1, 9, "Presidential Suite 103", 103, 4, false },
                    { 324, 1, 9, "Presidential Suite 104", 104, 4, false },
                    { 325, 1, 9, "Presidential Suite 105", 105, 4, false },
                    { 326, 1, 9, "Executive Suite 201", 201, 3, false },
                    { 327, 1, 9, "Executive Suite 202", 202, 3, false },
                    { 328, 1, 9, "Executive Suite 203", 203, 3, false },
                    { 329, 1, 9, "Executive Suite 204", 204, 3, false },
                    { 330, 1, 9, "Executive Suite 205", 205, 3, false },
                    { 331, 1, 9, "Executive Suite 206", 206, 3, false },
                    { 332, 1, 9, "Executive Suite 207", 207, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "BedCount", "HotelId", "RoomName", "RoomNumber", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 333, 1, 9, "Executive Suite 208", 208, 3, false },
                    { 334, 1, 9, "Executive Suite 209", 209, 3, false },
                    { 335, 1, 9, "Executive Suite 210", 210, 3, false },
                    { 336, 2, 9, "Deluxe Room 301", 301, 1, false },
                    { 337, 2, 9, "Deluxe Room 302", 302, 1, false },
                    { 338, 2, 9, "Deluxe Room 303", 303, 1, false },
                    { 339, 2, 9, "Deluxe Room 304", 304, 1, false },
                    { 340, 2, 9, "Deluxe Room 305", 305, 1, false },
                    { 341, 2, 9, "Deluxe Room 306", 306, 1, false },
                    { 342, 2, 9, "Deluxe Room 307", 307, 1, false },
                    { 343, 2, 9, "Deluxe Room 308", 308, 1, false },
                    { 344, 2, 9, "Deluxe Room 309", 309, 1, false },
                    { 345, 2, 9, "Deluxe Room 310", 310, 1, false },
                    { 346, 2, 9, "Deluxe Room 311", 311, 1, false },
                    { 347, 2, 9, "Deluxe Room 312", 312, 1, false },
                    { 348, 2, 9, "Deluxe Room 313", 313, 1, false },
                    { 349, 2, 9, "Deluxe Room 314", 314, 1, false },
                    { 350, 2, 9, "Deluxe Room 315", 315, 1, false },
                    { 351, 2, 9, "Super Deluxe Room 401", 401, 2, false },
                    { 352, 2, 9, "Super Deluxe Room 402", 402, 2, false },
                    { 353, 2, 9, "Super Deluxe Room 403", 403, 2, false },
                    { 354, 2, 9, "Super Deluxe Room 404", 404, 2, false },
                    { 355, 2, 9, "Super Deluxe Room 405", 405, 2, false },
                    { 356, 2, 9, "Super Deluxe Room 406", 406, 2, false },
                    { 357, 2, 9, "Super Deluxe Room 407", 407, 2, false },
                    { 358, 2, 9, "Super Deluxe Room 408", 408, 2, false },
                    { 359, 2, 9, "Super Deluxe Room 409", 409, 2, false },
                    { 360, 2, 9, "Super Deluxe Room 410", 410, 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360);
        }
    }
}
