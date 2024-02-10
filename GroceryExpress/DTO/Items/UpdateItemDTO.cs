using GroceryExpress.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Items
{
    public class UpdateItemDTO
    {

        [Required, MaxLength(100), MinLength(2)]
        public string Name { get; set; } = null!;


        [Required, MaxLength(100), MinLength(5)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required, MaxLength(100)]
        public string Brand { get; set; } = null!;

        [Required]
        public GroceryCategory Category { get; set; }

        public DateOnly AddedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [Required]
        public string ImageUrl { get; set; } = null!;

    }
}
