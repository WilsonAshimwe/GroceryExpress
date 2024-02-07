using GroceryExpress.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations;


namespace GroceryExpress.API.DTO.Addresses
{
    public class ShowAddressDTO
    {
        public string Street { get; set; } = null!;

        public string Number { get; set; } = null!;

        public string? Box { get; set; }

        public string City { get; set; } = null!;


        public int PostalCode { get; set; }

        public string Country { get; set; } = "Belgium";
    }
}

