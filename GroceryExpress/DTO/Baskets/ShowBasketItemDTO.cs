using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Baskets
{
    public class ShowBasketItemDTO
    {
        public int BasketId { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        public decimal ItemsTotal { get => Quantity * ItemPrice; }


    }
}
