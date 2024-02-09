using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.DAL.Seeders
{
    public static class ItemSeed
    {

        public static List<Item> Items = new List<Item>
        {
            new Item
            { Id = 1, Name = "Apple", Description = "Fresh and juicy", Price = 1.99m, Brand= "Gala", Category = GroceryCategory.Fruits, ImageUrl = "https://example.com/apple_image.jpg" },
            new Item { Id = 2, Name = "Banana", Description = "Ripe and sweet", Price = 0.99m, Brand="Chiquita", Category = GroceryCategory.Fruits, ImageUrl = "https://example.com/banana_image.jpg" },
            new Item { Id = 3, Name = "Milk", Description = "Whole milk", Price = 2.49m, Brand="Alpro", Category = GroceryCategory.Dairy, ImageUrl = "https://example.com/milk_image.jpg" },
            new Item { Id = 4, Name = "Bread", Description = "Whole wheat bread", Price = 2.29m, Brand="Jacquet", Category = GroceryCategory.Bakery, ImageUrl = "https://example.com/bread_image.jpg" },
            new Item { Id = 5, Name = "Chicken", Description = "Boneless skinless chicken breast", Price = 4.99m, Brand="Maïski", Category = GroceryCategory.Meat, ImageUrl = "https://example.com/chicken_image.jpg" },
            new Item { Id = 6, Name = "Spinach", Description = "Fresh organic spinach", Price = 1.49m, Brand="Iglo", Category = GroceryCategory.Vegetables, ImageUrl = "https://example.com/spinach_image.jpg" },
            new Item { Id = 7, Name = "Yogurt", Description = "Low-fat yogurt", Price = 1.79m, Brand="Alpro", Category = GroceryCategory.Dairy, ImageUrl = "https://example.com/yogurt_image.jpg" },
            new Item { Id = 8, Name = "Eggs", Description = "Large brown eggs", Price = 2.99m, Brand="Columbus", Category = GroceryCategory.Other, ImageUrl = "https://example.com/eggs_image.jpg" },
            new Item { Id = 9, Name = "Orange Juice", Description = "100% pure orange juice", Price = 3.49m, Brand= "Tropicana", Category = GroceryCategory.Beverages, ImageUrl = "https://example.com/orangejuice_image.jpg" },
            new Item { Id = 10, Name = "Chocolate", Description = "Milk chocolate bar", Price = 1.29m, Brand="Galak",  Category = GroceryCategory.SweetFood, ImageUrl = "https://example.com/chocolate_image.jpg" }
        };
    }
}
