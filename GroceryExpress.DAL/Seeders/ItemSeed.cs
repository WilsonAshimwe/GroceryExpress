using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace GroceryExpress.DAL.Seeders
{
    public static class ItemSeed
    {
        // .\wwwroot\images\8220646f-eaf2-4789-8c31-4c8507e52991IMG_0760.jpg
        public static List<Item> Items = new List<Item>
        {
            new Item
            { Id = 1, Name = "Apple", Description = "Fresh and juicy", Price = 1.99m, Brand= "Gala", Category = GroceryCategory.Fruits, ImageUrl = "images\\galaapplejuiced.jpg" },
            new Item { Id = 2, Name = "Banana", Description = "Ripe and sweet", Price = 0.99m, Brand="Chiquita", Category = GroceryCategory.Fruits, ImageUrl = "images\\Chiquitabanana.jpg"},
            new Item { Id = 3, Name = "Milk", Description = "Whole milk", Price = 2.49m, Brand="Alpro", Category = GroceryCategory.Dairy, ImageUrl = "images\\alpromilk.jpg" },
            new Item { Id = 4, Name = "Bread", Description = "Whole wheat bread", Price = 2.29m, Brand="Jacquet", Category = GroceryCategory.Bakery, ImageUrl = "images\\jacquetbread.jpg" },
            new Item { Id = 5, Name = "Chicken", Description = "Boneless skinless chicken breast", Price = 4.99m, Brand="Maïski", Category = GroceryCategory.Meat, ImageUrl = "images\\maiskichicken.jpg" },
            new Item { Id = 6, Name = "Spinach", Description = "Fresh organic spinach", Price = 1.49m, Brand="Iglo", Category = GroceryCategory.Vegetables, ImageUrl = "images\\iglospinach.jpg" },
            new Item { Id = 7, Name = "Yogurt", Description = "Low-fat yogurt", Price = 1.79m, Brand="Alpro", Category = GroceryCategory.Dairy, ImageUrl = "images\\alproyogourt.jpg" },
            new Item { Id = 8, Name = "Eggs", Description = "Large brown eggs", Price = 2.99m, Brand="Columbus", Category = GroceryCategory.Other, ImageUrl = "images\\columbuseggs.jpg" },
            new Item { Id = 9, Name = "Orange Juice", Description = "100% pure orange juice", Price = 3.49m, Brand= "Tropicana", Category = GroceryCategory.Beverages, ImageUrl = "images\\tropicanaorangejuice.jpg" },
            new Item { Id = 10, Name = "Chocolate", Description = "Milk chocolate bar", Price = 1.29m, Brand="Galak",  Category = GroceryCategory.SweetFood, ImageUrl = "images\\chocolatgalak.jpg" }
        };
    }
}
