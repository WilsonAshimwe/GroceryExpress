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
            new Item { Id = 10, Name = "Chocolate", Description = "Milk chocolate bar", Price = 1.29m, Brand="Galak",  Category = GroceryCategory.SweetFood, ImageUrl = "images\\chocolatgalak.jpg" },
            new Item { Id = 11, Name = "Essential Fruit & Nut Muesli", Description = "Oat, wheat and barley flakes with mixed dried fruits, nuts and seeds", Price = 3m, Brand="Waitrose ",  Category = GroceryCategory.Cerials, ImageUrl = "images\\essentialfoodandnut.jpg" },
            new Item { Id = 12, Name = "Cadbury Brunch Bar Raisin", Description = "Cereal (34 %) and Raisin (9.5 %) Bar Half Covered with Milk Chocolate (19 %).", Price = 1.55m, Brand="Waitrose ",  Category = GroceryCategory.Cerials, ImageUrl = "images\\LN_002834_BP_11.jpg" },
            new Item { Id = 13, Name = "Lu Le Petit Citron Lemon Soft Bakes", Description = "Lemon flavoured soft bakes.", Price = 1.55m, Brand="Waitrose ",  Category = GroceryCategory.SweetFood, ImageUrl = "images\\LN_895684_BP_11;jpg" },
            new Item { Id = 14, Name = "Flash Task Kitchen Spray Fresh Citrus800ml", Description = "Kitchen degreaser. Removes up to 100% of grease. With plant-based ingredient (12% of total surfactant, which are subject to processing).", Price = 2.5m, Brand="Flash",  Category = GroceryCategory.CleaningProduct, ImageUrl = "images\\LN_002490_BP_11.jpg" },
            new Item { Id = 15, Name = "Nivea For Men Sensitive Gel200ml", Description = "Instantly protects from 5 signs of skin irritation: burning, redness, dryness, tightness & micro cuts.", Price = 4.25m, Brand="Nivea",  Category = GroceryCategory.PersonalCare, ImageUrl = "LN_060554_BP_11.jpg" },
            new Item { Id = 16, Name = "Waitrose Frozen Cod Fillets MSC475g", Description = "Lovely frozen cod wihich is absolutely delicious.", Price = 8.50m, Brand="Waitrose",  Category = GroceryCategory.FrozenFoods, ImageUrl = "LN_847760_BP_11.jpg" },
            new Item { Id = 17, Name = "Young's Gastro Salt & Pepper Dusted Basa Fillets 2s310g", Description = "Basa fillets dusted in a flour breadcrumb coating, with sea salt and cracked black pepper", Price = 4.50m, Brand="Iglo",  Category = GroceryCategory.FrozenFoods, ImageUrl = "LN_821034_BP_11" },
        };
    }
}
