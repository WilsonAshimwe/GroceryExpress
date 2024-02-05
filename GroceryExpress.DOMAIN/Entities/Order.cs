using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Item> Items { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public Shop Shop { get; set; }

        [ForeignKey("Deliverer")]

        public int DelivererId { get; set; }

        public Deliverer Deliverer { get; set; }










    }
}
