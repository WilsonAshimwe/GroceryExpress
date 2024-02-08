using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class ItemOrder
    {

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; } = 1;


        [Column(TypeName = "decimal(5, 2)")]

        public decimal ItemPrice { get; set; }




    }
}
