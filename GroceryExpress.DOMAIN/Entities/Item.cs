using GroceryExpress.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.DOMAIN.Entities
{

    public class Item
    {

        public Item()
        {
            Orders = new HashSet<Order>();

            Shops = new HashSet<Shop>();

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public GroceryCategory Category { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}
