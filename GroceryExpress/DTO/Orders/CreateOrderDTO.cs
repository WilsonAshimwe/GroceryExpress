using GroceryExpress.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Orders
{
    public class CreateOrderDTO
    {
        [Required]
        public int DelivererId { get; set; }
        [Required]
        public ICollection<Item> items { get; set; }

    }
}
