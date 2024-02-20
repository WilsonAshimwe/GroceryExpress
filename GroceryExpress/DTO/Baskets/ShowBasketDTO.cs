using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Baskets
{
    public class ShowBasketDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<ShowBasketItemDTO> BasketItems { get; set; }


        public decimal SubTotal { get => BasketItems.Sum(io => io.Quantity * io.ItemPrice); }
        public decimal Shipping { get => SubTotal / 10; }
        public decimal Total { get => SubTotal + (SubTotal / 10); }

        public int TotalElements { get => (BasketItems.Sum(io => io.Quantity)); }






        public DateTime BasketDate { get; set; }
    }
}
