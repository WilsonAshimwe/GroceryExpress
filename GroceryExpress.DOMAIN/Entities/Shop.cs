using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        [ForeignKey("Address")]
        public int AddressId { get; set; } 

        public Address Address { get; set; } = null!;

        public ICollection<Item> Items { get; set; }
    }
}
