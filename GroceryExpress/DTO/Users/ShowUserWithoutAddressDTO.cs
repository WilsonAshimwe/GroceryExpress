namespace GroceryExpress.API.DTO.Users
{
    public class ShowUserWithoutAddressDTO
    {


        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public DateOnly BirthDate { get; set; }
    }


}
