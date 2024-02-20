using GroceryExpress.BLL.Infrastructures;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.DAL.Seeders
{
    public static class UserSeed
    {
        // Create a list of 25 users
        public static List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Username = "johndoe",
                Email = "john.doe@example.com",
                Password= new PasswordHasher().Hash("john.doe@example.com" + "January"),
                PhoneNumber = "123-456-7890",
                BirthDate = new DateOnly(1990, 1, 1),
                AddressId = 1,
            },
            new User
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Username = "janesmith",
                Email = "jane.smith@example.com",
                Password= new PasswordHasher().Hash("jane.smith@example.com" +"February"),
                PhoneNumber = "987-654-3210",
                BirthDate = new DateOnly(1985, 5, 15),
                AddressId = 2

            },
            // Add 18 more users with unique data
            new User
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Username = "alicejohnson",
                Email = "alice.johnson@example.com",
                Password= new PasswordHasher().Hash("alice.johnson@example.com" + "March"),
                PhoneNumber = "555-123-4567",
                BirthDate = new DateOnly(1988, 8, 20),
                AddressId = 3,
            },
            // Add 5 more users with unique data
            new User
            {
                Id = 4,
                FirstName = "Bob",
                LastName = "Williams",
                Username = "bobwilliams",
                Email = "bob.williams@example.com",
                Password= new PasswordHasher().Hash("bob.williams@example.com"+ "April"),
                PhoneNumber = "111-222-3333",
                BirthDate = new DateOnly(1975, 3, 10),
                AddressId = 4,

            },
            // Add 4 more users with unique data
            new User
            {
                Id = 5,
                FirstName = "Eva",
                LastName = "Brown",
                Username = "evabrown",
                Email = "eva.brown@example.com",
                Password= new PasswordHasher().Hash("eva.brown@example.com"+"May"),
                PhoneNumber = "777-888-9999",
                BirthDate = new DateOnly(1992, 11, 25),
                AddressId = 5,
            },
            // Add 3 more users with unique data
            new User
            {
                Id = 6,
                FirstName = "David",
                LastName = "Clark",
                Username = "davidclark",
                Email = "david.clark@example.com",
                Password= new PasswordHasher().Hash("david.clark@example.com"+ "June"),
                PhoneNumber = "444-555-6666",
                BirthDate = new DateOnly(1982, 7, 5),
                AddressId = 6,

            },
            // Add 2 more users with unique data
            new User
            {
                Id = 7,
                FirstName = "Grace",
                LastName = "Miller",
                Username = "gracemiller",
                Email = "grace.miller@example.com",
                Password= new PasswordHasher().Hash("grace.miller@example.com"+"July"),
                PhoneNumber = "999-000-1111",
                BirthDate = new DateOnly(1995, 4, 15),
                AddressId = 7,

            },
            // Add 1 more user with unique data
            new User
            {
                Id = 8,
                FirstName = "Sam",
                LastName = "Anderson",
                Username = "samanderson",
                Email = "sam.anderson@example.com",
                Password= new PasswordHasher().Hash("sam.anderson@example.com"+ "August"),
                PhoneNumber = "222-333-4444",
                BirthDate = new DateOnly(1978, 9, 30),
                AddressId = 8,

            },


        };
        public static List<Address> addresses = new List<Address>() {
            new Address
            {
                Id = 1,
                Street = "Main Street",
                Number = "123",
                Box = "A",
                City = "Example City",
                PostalCode = 12345
            },

               new Address
            {
                   Id = 2,

                Street = "Oak Avenue",
                Number = "456",
                Box = "B",
                City = "Sample Town",
                PostalCode = 67890
            },
                 new Address
            {
                     Id = 3,

                Street = "Birch Street",
                Number = "303",
                Box = "F",
                City = "New Town",
                PostalCode = 44556
            },
                new Address
            {
                    Id = 4,
                Street = "Cedar Drive",
                Number = "202",
                Box = "E",
                City = "Another City",
                PostalCode = 11223
            },
                 new Address
            {
                     Id = 5,
                Street = "Pine Lane",
                Number = "101",
                Box = "D",
                City = "Demo Town",
                PostalCode = 98765
            },
                  new Address
            {
                      Id = 6,
                Street = "Pine Lane",
                Number = "101",
                Box = "D",
                City = "Demo Town",
                PostalCode = 98765
            },
                new Address
            {
                    Id = 7,
                Street = "Maple Road",
                Number = "789",
                Box = "C",
                City = "Test City",
                PostalCode = 54321
            },
            new Address
            {
                Id = 8,

                Street = "Oak Avenue",
                Number = "456",
                Box = "B",
                City = "Sample Town",
                PostalCode = 67890
            },
        };

    }


}
