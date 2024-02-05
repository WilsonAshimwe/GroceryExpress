namespace GroceryExpress.DOMAIN.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; } = null!;

        public string Number { get; set; } = null!;

        public string Box { get; set; } = null!;
        public string City { get; set; } = null!;
        public int PostalCode { get; set; }
        public string Country { get; } = "Belgium";
    }
}
