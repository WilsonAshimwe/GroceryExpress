using GroceryExpress.API.DTO.Addresses;

namespace GroceryExpress.API.DTO.Users
{
    public class ShowUserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public DateOnly BirthDate { get; set; }

        public ShowAddressDTO Address { get; init; } = null!;
    }
}



