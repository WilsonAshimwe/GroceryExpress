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
                           DateTime birthdate,
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

    }
}
