using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Orders
{
    public class ShowItemOrderDTO
    {


        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal ItemPrice { get; set; }
        public decimal ItemsTotal { get => Quantity * ItemPrice; }

    }
}
