using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.API.DTO.Orders
{
    public class ShowOrderDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<ShowItemOrderDTO> ItemOrders { get; set; }


        public DateTime OrderDate { get; set; }
    }
}
