using GroceryExpress.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Users
{
    public class UpdateUserDTO
    {
        public UpdateUserDTO(User user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Username = user.Username;
            this.Email = user.Email;
            this.PhoneNumber = user.PhoneNumber;
            this.BirthDate = user.BirthDate;
            this.Street = user.Address.Street;
            this.Number = user.Address.Number;
            this.Box = user.Address.Box;
            this.City = user.Address.City;
            this.PostalCode = user.Address.PostalCode;  
            this.Country = user.Address.Country;


            
        }

        [MaxLength(50), MinLength(2), Required]
        public string FirstName { get; set; } = null!;

        [MaxLength(50), MinLength(2), Required]
        public string LastName { get; set; } = null!;

        [MaxLength(50), MinLength(2), Required]
        public string Username { get; set; } = null!;
        [MaxLength(50), MinLength(12), Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required, RegularExpression(@"^+32\d{8}$")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public DateOnly BirthDate { get; set; }

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
