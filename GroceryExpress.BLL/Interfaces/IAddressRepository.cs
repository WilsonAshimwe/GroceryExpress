using GroceryExpress.DOMAIN.Entities;
using GroceryExpress.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IAddressRepository
    {
        Task<Address?> Find(int id);

        Task<List<Address>> FindAll();

        Task<Address> Add(Address address);

        Task<Address> Update(Address address);
        Task Delete(Address address);
    }
}
