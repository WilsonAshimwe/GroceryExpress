using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(GroceryExpressContext _context) : base(_context)
        {

        }

        public async Task<List<Order>> FindAllWithItems()
        {
           return await _table.Include(o => o.ItemOrders).ThenInclude(io => io.Item).ToListAsync();
        }

    }
}
