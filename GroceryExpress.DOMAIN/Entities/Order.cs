using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Item> Items { get; set; }


        public int ShopId { get; set; }

        public Shop Shop { get; set; }


        public int DelivererId { get; set; }

        public Deliverer Deliverer { get; set; }










    }
}
