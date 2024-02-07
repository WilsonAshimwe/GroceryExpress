using GroceryExpress.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DAL.Seeders
{
    public static class ShopSeed
    {
        public static List<Shop> shops = new List<Shop>(){

            new Shop()
            {

                Id = 1,
                Name = "Morrisons",
                Email= "adam@gmail.com",
                PhoneNumber= "+32474211252",
                AddressId= 9
            },
               new Shop()
            {

                Id = 2,
                Name = "Ada",
                Email= "wilson@gmail.com",
                PhoneNumber= "+32474211253",
                AddressId= 10
            },

              new Shop()
            {

                Id = 3,
                Name = "Stefa",
                Email= "Stefa@gmail.com",
                PhoneNumber= "+32474211254",
                AddressId= 11
            },
               new Shop()

                {

                Id = 4,
                Name = "Stefania",
                Email= "Stefania@gmail.com",
                PhoneNumber= "+32474211255",
                AddressId= 12
            }
};

        public static List<Address> addresses = new List<Address>()
        {
            new Address { Id = 9, Street = "Main Street", Number = "123", Box = "A", City = "Anytown", PostalCode = 12345 },
            new Address { Id = 10, Street = "Elm Street", Number = "456", Box = "B", City = "Springfield", PostalCode = 67890 },
            new Address { Id = 11, Street = "Oak Avenue", Number = "789", Box = "C", City = "Smallville", PostalCode = 24680 },
            new Address { Id = 12, Street = "Pine Road", Number = "101", Box = "D", City = "Lakeside", PostalCode = 13579  },
        };

    }

}
    

