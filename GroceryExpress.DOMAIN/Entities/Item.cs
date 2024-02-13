using GroceryExpress.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{

    public class Item
    {

        public Item()
        {
            ItemOrders = new HashSet<ItemOrder>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Brand { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }


        public GroceryCategory Category { get; set; }

        public DateTime AddedDate { get; private set; } = DateTime.Now;

        public string ImageUrl { get; set; } = null!;

        public ICollection<ItemOrder> ItemOrders { get; set; }

    }
}
