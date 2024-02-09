using GroceryExpress.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IItemOrderRepository
    {
        Task<ItemOrder?> Find(int id);
        Task<List<ItemOrder>> FindAll();

        Task<ItemOrder> Add(ItemOrder itemOrder);

        Task<ItemOrder> Update(ItemOrder itemOrder);
        Task Delete(ItemOrder itemOrder);
    }
}
