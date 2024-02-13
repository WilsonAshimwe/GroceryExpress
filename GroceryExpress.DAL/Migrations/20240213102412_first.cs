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
                    { 1, new DateTime(2024, 2, 13, 11, 24, 11, 742, DateTimeKind.Local).AddTicks(6871), "Gala", "Fruits", "Fresh and juicy", "images\\galaapplejuiced.jpg", "Apple", 1.99m },
                    { 2, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3712), "Chiquita", "Fruits", "Ripe and sweet", "images\\Chiquitabanana.jpg", "Banana", 0.99m },
                    { 3, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3752), "Alpro", "Dairy", "Whole milk", "images\\alpromilk.jpg", "Milk", 2.49m },
                    { 4, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3757), "Jacquet", "Bakery", "Whole wheat bread", "images\\jacquetbread.jpg", "Bread", 2.29m },
                    { 5, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3761), "Maïski", "Meat", "Boneless skinless chicken breast", "images\\maiskichicken.jpg", "Chicken", 4.99m },
                    { 6, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3772), "Iglo", "Vegetables", "Fresh organic spinach", "images\\iglospinach.jpg", "Spinach", 1.49m },
                    { 7, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3775), "Alpro", "Dairy", "Low-fat yogurt", "images\\alproyogourt.jpg", "Yogurt", 1.79m },
                    { 8, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3779), "Columbus", "Other", "Large brown eggs", "images\\columbuseggs.jpg", "Eggs", 2.99m },
                    { 9, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3782), "Tropicana", "Beverages", "100% pure orange juice", "images\\tropicanaorangejuice.jpg", "Orange Juice", 3.49m },
                    { 10, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3786), "Galak", "SweetFood", "Milk chocolate bar", "images\\chocolatgalak.jpg", "Chocolate", 1.29m },
                    { 11, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3790), "Waitrose ", "Cerials", "Oat, wheat and barley flakes with mixed dried fruits, nuts and seeds", "images\\essentialfoodandnut.jpg", "Essential Fruit & Nut Muesli", 3m },
                    { 12, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3803), "Waitrose ", "Cerials", "Cereal (34 %) and Raisin (9.5 %) Bar Half Covered with Milk Chocolate (19 %).", "images\\LN_002834_BP_11.jpg", "Cadbury Brunch Bar Raisin", 1.55m },
                    { 13, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3866), "Waitrose ", "SweetFood", "Lemon flavoured soft bakes.", "images\\LN_895684_BP_11;jpg", "Lu Le Petit Citron Lemon Soft Bakes", 1.55m },
                    { 14, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3871), "Flash", "CleaningProduct", "Kitchen degreaser. Removes up to 100% of grease. With plant-based ingredient (12% of total surfactant, which are subject to processing).", "images\\LN_002490_BP_11.jpg", "Flash Task Kitchen Spray Fresh Citrus800ml", 2.5m },
                    { 15, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3874), "Nivea", "PersonalCare", "Instantly protects from 5 signs of skin irritation: burning, redness, dryness, tightness & micro cuts.", "LN_060554_BP_11.jpg", "Nivea For Men Sensitive Gel200ml", 4.25m },
                    { 16, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3878), "Waitrose", "FrozenFoods", "Lovely frozen cod wihich is absolutely delicious.", "LN_847760_BP_11.jpg", "Waitrose Frozen Cod Fillets MSC475g", 8.50m },
                    { 17, new DateTime(2024, 2, 13, 11, 24, 11, 746, DateTimeKind.Local).AddTicks(3881), "Iglo", "FrozenFoods", "Basa fillets dusted in a flour breadcrumb coating, with sea salt and cracked black pepper", "LN_821034_BP_11", "Young's Gastro Salt & Pepper Dusted Basa Fillets 2s310g", 4.50m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(1990, 1, 1), "john.doe@example.com", "John", "Doe", "123-456-7890", "Customer", "johndoe" },
                    { 2, 2, new DateOnly(1985, 5, 15), "jane.smith@example.com", "Jane", "Smith", "987-654-3210", "Customer", "janesmith" },
                    { 3, 3, new DateOnly(1988, 8, 20), "alice.johnson@example.com", "Alice", "Johnson", "555-123-4567", "Customer", "alicejohnson" },
                    { 4, 4, new DateOnly(1975, 3, 10), "bob.williams@example.com", "Bob", "Williams", "111-222-3333", "Customer", "bobwilliams" },
                    { 5, 5, new DateOnly(1992, 11, 25), "eva.brown@example.com", "Eva", "Brown", "777-888-9999", "Customer", "evabrown" },
                    { 6, 6, new DateOnly(1982, 7, 5), "david.clark@example.com", "David", "Clark", "444-555-6666", "Customer", "davidclark" },
                    { 7, 7, new DateOnly(1995, 4, 15), "grace.miller@example.com", "Grace", "Miller", "999-000-1111", "Customer", "gracemiller" },
                    { 8, 8, new DateOnly(1978, 9, 30), "sam.anderson@example.com", "Sam", "Anderson", "222-333-4444", "Customer", "samanderson" }
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
