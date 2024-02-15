using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroceryExpress.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deliverers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliverers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Box", "City", "Number", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "A", "Example City", "123", 12345, "Main Street" },
                    { 2, "B", "Sample Town", "456", 67890, "Oak Avenue" },
                    { 3, "F", "New Town", "303", 44556, "Birch Street" },
                    { 4, "E", "Another City", "202", 11223, "Cedar Drive" },
                    { 5, "D", "Demo Town", "101", 98765, "Pine Lane" },
                    { 6, "D", "Demo Town", "101", 98765, "Pine Lane" },
                    { 7, "C", "Test City", "789", 54321, "Maple Road" },
                    { 8, "B", "Sample Town", "456", 67890, "Oak Avenue" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AddedDate", "Brand", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 13, 28, 11, 385, DateTimeKind.Local).AddTicks(1879), "Gala", "Fruits", "Fresh and juicy", "images\\galaapplejuiced.jpg", "Apple", 1.99m },
                    { 2, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8644), "Chiquita", "Fruits", "Ripe and sweet", "images\\Chiquitabanana.jpg", "Banana", 0.99m },
                    { 3, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8698), "Alpro", "Dairy", "Whole milk", "images\\alpromilk.jpg", "Milk", 2.49m },
                    { 4, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8703), "Jacquet", "Bakery", "Whole wheat bread", "images\\jacquetbread.jpg", "Bread", 2.29m },
                    { 5, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8707), "Maïski", "Meat", "Boneless skinless chicken breast", "images\\maiskichicken.jpg", "Chicken", 4.99m },
                    { 6, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8796), "Iglo", "Vegetables", "Fresh organic spinach", "images\\iglospinach.jpg", "Spinach", 1.49m },
                    { 7, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8801), "Alpro", "Dairy", "Low-fat yogurt", "images\\alproyogourt.jpg", "Yogurt", 1.79m },
                    { 8, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8805), "Columbus", "Other", "Large brown eggs", "images\\columbuseggs.jpg", "Eggs", 2.99m },
                    { 9, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8809), "Tropicana", "Beverages", "100% pure orange juice", "images\\tropicanaorangejuice.jpg", "Orange Juice", 3.49m },
                    { 10, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8814), "Galak", "SweetFood", "Milk chocolate bar", "images\\chocolatgalak.jpg", "Chocolate", 1.29m },
                    { 11, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8818), "Waitrose ", "Cerials", "Oat, wheat and barley flakes with mixed dried fruits, nuts and seeds", "images\\essentialfoodandnut.jpg", "Essential Fruit & Nut Muesli", 3m },
                    { 12, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8833), "Waitrose ", "Cerials", "Cereal (34 %) and Raisin (9.5 %) Bar Half Covered with Milk Chocolate (19 %).", "images\\LN_002834_BP_11.jpg", "Cadbury Brunch Bar Raisin", 1.55m },
                    { 13, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8837), "Waitrose ", "SweetFood", "Lemon flavoured soft bakes.", "images\\LN_895684_BP_11.jpg", "Lu Le Petit Citron Lemon Soft Bakes", 1.55m },
                    { 14, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8841), "Flash", "CleaningProduct", "Kitchen degreaser. Removes up to 100% of grease. With plant-based ingredient (12% of total surfactant, which are subject to processing).", "images\\LN_002490_BP_11.jpg", "Flash Task Kitchen Spray Fresh Citrus800ml", 2.5m },
                    { 15, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8844), "Nivea", "PersonalCare", "Instantly protects from 5 signs of skin irritation: burning, redness, dryness, tightness & micro cuts.", "images\\LN_060554_BP_11.jpg", "Nivea For Men Sensitive Gel200ml", 4.25m },
                    { 16, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8848), "Waitrose", "FrozenFoods", "Lovely frozen cod wihich is absolutely delicious.", "images\\LN_847760_BP_11.jpg", "Waitrose Frozen Cod Fillets MSC475g", 8.50m },
                    { 17, new DateTime(2024, 2, 15, 13, 28, 11, 388, DateTimeKind.Local).AddTicks(8852), "Iglo", "FrozenFoods", "Basa fillets dusted in a flour breadcrumb coating, with sea salt and cracked black pepper", "images\\LN_821034_BP_11.jpg", "Young's Gastro Salt & Pepper Dusted Basa Fillets 2s310g", 4.50m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "BirthDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(1990, 1, 1), "john.doe@example.com", "John", "Doe", new byte[] { 186, 186, 111, 17, 248, 145, 146, 14, 212, 140, 235, 142, 214, 186, 1, 0, 138, 81, 162, 1, 124, 197, 191, 156, 131, 127, 25, 172, 215, 229, 13, 103, 180, 95, 117, 209, 88, 137, 84, 24, 201, 212, 97, 136, 145, 77, 54, 186, 221, 80, 82, 196, 253, 150, 20, 106, 108, 7, 37, 21, 32, 212, 55, 82 }, "123-456-7890", "Customer", "johndoe" },
                    { 2, 2, new DateOnly(1985, 5, 15), "jane.smith@example.com", "Jane", "Smith", new byte[] { 149, 219, 31, 239, 73, 187, 203, 41, 96, 155, 74, 160, 164, 204, 190, 55, 204, 2, 59, 170, 195, 28, 233, 3, 154, 176, 240, 91, 103, 120, 26, 33, 217, 40, 88, 15, 86, 253, 97, 75, 217, 38, 183, 205, 140, 51, 227, 70, 203, 244, 254, 42, 167, 48, 225, 3, 139, 13, 168, 162, 55, 100, 198, 194 }, "987-654-3210", "Customer", "janesmith" },
                    { 3, 3, new DateOnly(1988, 8, 20), "alice.johnson@example.com", "Alice", "Johnson", new byte[] { 75, 210, 226, 158, 139, 186, 242, 228, 191, 158, 200, 152, 6, 77, 167, 181, 115, 33, 36, 19, 208, 233, 45, 22, 3, 10, 134, 33, 145, 68, 28, 37, 192, 94, 13, 220, 252, 79, 66, 61, 14, 236, 86, 191, 215, 123, 67, 103, 114, 192, 213, 90, 139, 255, 127, 247, 5, 228, 240, 51, 78, 88, 185, 165 }, "555-123-4567", "Customer", "alicejohnson" },
                    { 4, 4, new DateOnly(1975, 3, 10), "bob.williams@example.com", "Bob", "Williams", new byte[] { 195, 234, 245, 81, 46, 77, 181, 197, 182, 53, 39, 243, 112, 4, 150, 64, 69, 21, 135, 123, 70, 122, 146, 120, 47, 187, 62, 75, 165, 33, 38, 15, 245, 247, 225, 80, 170, 57, 59, 63, 186, 195, 131, 144, 156, 164, 112, 225, 4, 144, 153, 4, 230, 220, 130, 79, 188, 41, 63, 207, 78, 184, 27, 32 }, "111-222-3333", "Customer", "bobwilliams" },
                    { 5, 5, new DateOnly(1992, 11, 25), "eva.brown@example.com", "Eva", "Brown", new byte[] { 198, 77, 128, 237, 255, 243, 143, 108, 226, 171, 107, 202, 170, 68, 36, 99, 59, 164, 97, 136, 54, 56, 56, 82, 45, 111, 25, 225, 155, 8, 126, 118, 9, 4, 88, 192, 191, 13, 165, 71, 174, 118, 57, 209, 204, 83, 102, 21, 28, 7, 196, 212, 177, 68, 201, 185, 191, 167, 130, 240, 80, 168, 173, 29 }, "777-888-9999", "Customer", "evabrown" },
                    { 6, 6, new DateOnly(1982, 7, 5), "david.clark@example.com", "David", "Clark", new byte[] { 62, 34, 117, 240, 79, 194, 195, 242, 25, 167, 24, 114, 194, 74, 201, 62, 196, 199, 144, 146, 112, 186, 88, 28, 246, 167, 185, 240, 27, 106, 104, 127, 109, 6, 21, 95, 7, 63, 201, 80, 240, 165, 21, 51, 233, 122, 64, 198, 119, 181, 56, 101, 55, 104, 250, 219, 60, 100, 5, 230, 181, 190, 166, 101 }, "444-555-6666", "Customer", "davidclark" },
                    { 7, 7, new DateOnly(1995, 4, 15), "grace.miller@example.com", "Grace", "Miller", new byte[] { 216, 43, 62, 55, 208, 60, 249, 94, 186, 225, 243, 115, 45, 252, 131, 162, 186, 180, 131, 4, 224, 198, 38, 218, 202, 106, 114, 113, 241, 125, 11, 146, 41, 181, 204, 150, 213, 89, 110, 217, 244, 9, 187, 173, 95, 8, 46, 164, 241, 227, 42, 59, 128, 167, 161, 120, 132, 2, 16, 116, 46, 35, 153, 114 }, "999-000-1111", "Customer", "gracemiller" },
                    { 8, 8, new DateOnly(1978, 9, 30), "sam.anderson@example.com", "Sam", "Anderson", new byte[] { 89, 110, 216, 84, 7, 228, 243, 177, 159, 33, 30, 131, 126, 175, 160, 138, 242, 155, 178, 47, 203, 134, 213, 127, 252, 50, 151, 23, 50, 27, 41, 149, 98, 174, 202, 159, 155, 70, 203, 32, 66, 229, 106, 29, 3, 126, 83, 181, 178, 249, 54, 29, 140, 245, 28, 32, 147, 132, 22, 145, 246, 50, 206, 185 }, "222-333-4444", "Customer", "samanderson" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressId",
                table: "Users",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliverers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
