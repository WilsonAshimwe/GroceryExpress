using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class CustomerService(ICustomerRepository _customerRepository)
    {
        public Customer Add(string firstname,
                           string lastname,
                           string username,
                           string email,
                           string phonenumber,
                           DateOnly birthdate,
                           string street,
                           string number,
                           string? box,
                           string city,
                           int postalcode)
        {


            Address address = new Address()
            {
                Street = street,
                Number = number,
                Box = box,
                City = city,
                PostalCode = postalcode

            };

            return _customerRepository.Add(

                new Customer()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Username = username,
                    Email = email,
                    PhoneNumber = phonenumber,
                    BirthDate = birthdate,
                    Address = address,
                }

);

        }

        public Customer? Get(int id)
        {
            Customer? customer= _customerRepository.Find(id);
            if (customer == null)
            {
                throw new KeyNotFoundException($"There is not customer with id {id}");
            }
            return customer;
        }

        public void Delete(int id) {

            Customer? customer = _customerRepository.Find(id);
            if (customer == null)
            {
                throw new KeyNotFoundException($"There is not customer with id {id}");
            }
            _customerRepository.Delete(customer);



        }

        public void Update(int id, 
                           string firstname, 
                           string lastname, 
                           string username, 
                           string email,
                           string phonenumber, 
                           DateOnly birthdate, 
                           string street,
                           string number,
                           string? box,
                           string city,
                           int postalcode) {

            Customer? customer = _customerRepository.Find(id);
            if (customer is null)
            {
                throw new KeyNotFoundException($"the customer with {id} cannot be found");
            };

            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Username = username;
            customer.Email = email;
            customer.PhoneNumber = phonenumber;
            customer.BirthDate = birthdate;
            customer.Address.Street = street;
            customer.Address.Number = number;
            customer.Address.Box= box;
            customer.Address.City = city;
            customer.Address.PostalCode = postalcode;

        }

    }
}
