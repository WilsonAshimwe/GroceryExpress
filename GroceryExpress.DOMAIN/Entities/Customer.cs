using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(50), MinLength(2)]
        public string FirstName { get; set; } = null!;

        [MaxLength(50), MinLength(2)]
        public string LastName { get; set; } = null!;

        [MaxLength(50), MinLength(2)]
        public string Username { get; set; } = null!;
        [MaxLength(50), MinLength(12)]
        public string Email { get; set; } = null!;
        [MaxLength(20)]
        public string PhoneNumber { get; set; } = null!;
        public DateOnly BirthDate { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;

        public ICollection<Order> Orders { get; set; }



    }
}
