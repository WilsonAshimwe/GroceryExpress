using GroceryExpress.Domain.Enums;

namespace GroceryExpress.API.DTO.Items
{
    public class ShowItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string Brand { get; set; } = null!;

        public GroceryCategory Category { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public string ImageUrl { get; set; } = null!;


    }
}
