using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Baskets
{
    public class CreateBasketDTO
    {
        public int UserId { get; set; }
        [Required]
        public List<CreateBasketItemDTO> basketItems { get; set; }
    }
}
