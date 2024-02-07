using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Addresses
{
    public class CreateAddressDTO
    {
        [Required, MaxLength(255)]
        public string Street { get; set; } = null!;

        [Required, MaxLength(5)]
        public string Number { get; set; } = null!;
        [MaxLength(5)]
        public string? Box { get; set; }
        [Required, MaxLength(20)]
        public string City { get; set; } = null!;

        [Range(1, 9999)]
        public int PostalCode { get; set; }

        public string Country { get; } = "Belgium";
    }
}
