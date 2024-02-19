using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Baskets
{
    public class BasketDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<ShowBasketItemDTO> BasketItems { get; set; }

        public decimal Total { get => BasketItems.Sum(io => io.Quantity * io.ItemPrice); }

       

        public DateTime BasketDate { get; set; }
    }
}
