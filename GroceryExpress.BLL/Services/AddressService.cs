using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class AddressService(IAddressRepository _addressRepository)
    {
        public async Task<Address> Add(string street, string number, string box, string city, int postalcode)
        {
            return await _addressRepository.Add(

                new Address()
                {
                    Street = street,
                    Number = number,
                    Box = box,
                    City = city,
                    PostalCode = postalcode
                });

        }
        public async Task<Address> Get(int id)
        {

            Address? address = await _addressRepository.Find(id);
            if (address == null)
            {
                throw new KeyNotFoundException($"There is no address with id {id}");
            }
            return address;
        }

        public async Task<List<Address>> GetAll()
        {
            return await _addressRepository.FindAll();

        }

        public async Task Delete(int id)
        {

            Address? Address = await _addressRepository.Find(id);
            if (Address == null)
            {
                throw new KeyNotFoundException($"There is no Address with id {id}");
            }
            await _addressRepository.Delete(Address);

        }

        public async Task<Address> Update(int id, string street, string number, string box, string city, int postalcode)
        {

            Address? address = await _addressRepository.Find(id);
            if (address is null)
            {
                throw new KeyNotFoundException($"the address with {id} cannot be found");
            };

            address.Street = street;
            address.Number = number;
            address.Box = box;
            address.City = city;
            address.PostalCode = postalcode;
            return await _addressRepository.Update(address);
        }

    }
}
