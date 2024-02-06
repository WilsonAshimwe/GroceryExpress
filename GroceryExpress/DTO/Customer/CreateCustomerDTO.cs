using GroceryExpress.API.DTO.Address;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Customer
{
    public class CreateCustomerDTO
    {

        [MaxLength(50), MinLength(2), Required]
        public string FirstName { get; set; } = null!;

        [MaxLength(50), MinLength(2), Required]
        public string LastName { get; set; } = null!;

        [MaxLength(50), MinLength(2), Required]
        public string Username { get; set; } = null!;
        [MaxLength(50), MinLength(12), Required, EmailAddress]
        public string Email { get; set; } = null!;
        [MaxLength(20), Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public CreateAddressDTO AddressDTO { get; set; } = null!;

    }
}
