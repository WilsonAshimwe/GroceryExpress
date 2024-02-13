using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Orders
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<ShowItemOrderDTO> ItemOrders { get; set; }

        public decimal Total { get => ItemOrders.Sum(io => io.Quantity * io.ItemPrice); }


        public DateTime OrderDate { get; set; }
    }
}
