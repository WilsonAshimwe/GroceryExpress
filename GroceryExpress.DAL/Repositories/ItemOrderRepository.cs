using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DAL.Repositories
{
    public class ItemOrderRepository : BaseRepository<ItemOrder>, IItemOrderRepository
    {
        public ItemOrderRepository(GroceryExpressContext context) : base(context)
        {
        }
    }
}
