using GroceryExpress.Domain.Enums;

namespace GroceryExpress.API.DTO.Items
{
    public class ShowItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public GroceryCategory Category { get; set; }

        public DateOnly AddedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string ItemImageUrl { get; set; } = null!;

    }
}
