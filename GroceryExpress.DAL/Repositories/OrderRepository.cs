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
        public async Task<Order?> FindByUser(int userId)
        {
            var order = await _table.Include(o => o.ItemOrders).ThenInclude(io => io.Item).Where(b => b.UserId == userId).FirstOrDefaultAsync();
            return order;
        }

        public async Task<Order?> FindById(int orderId)
        {
            var order = await _table.Include(o => o.ItemOrders).ThenInclude(io => io.Item).Where(b => b.Id == orderId).FirstOrDefaultAsync();
            return order;
        }
        public async Task<Order?> AddItemOrders(int userId, List<ItemOrder> itemOrders)
        {
            var order = await _table.Include(o => o.ItemOrders).ThenInclude(io => io.Item).Where(b => b.UserId == userId).FirstOrDefaultAsync();

            if (order != null)
            {
                for (int i = 0; i < itemOrders.Count; i++)
                {

                    var item = order.ItemOrders.Where(item => item.ItemId == itemOrders[i].ItemId).FirstOrDefault();
                    if (item != null)
                    {
                        item.Quantity += 1;
                        //itemOrders[i].Quantity = itemOrders[i].Quantity +1;    
                    }
                    else { order.ItemOrders.Add(itemOrders[i]); }


                }

                await _context.SaveChangesAsync();
            }

            return order;

        }
        public async Task<Order?> RemoveItemOrders(int userId, List<ItemOrder> itemOrders)
        {
            var order = await _table.Include(o => o.ItemOrders).ThenInclude(io => io.Item).Where(b => b.UserId == userId).FirstOrDefaultAsync();

            if (order != null)
            {
                for (int i = 0; i < itemOrders.Count; i++)
                {

                    var item = order.ItemOrders.Where(item => item.ItemId == itemOrders[i].ItemId).FirstOrDefault();
                    if (item != null)
                    {
                        item.Quantity -= 1;
                        //itemOrders[i].Quantity = itemOrders[i].Quantity +1;
                        if (item.Quantity == 0) { order.ItemOrders.Remove(item); }
                    }

                }

                await _context.SaveChangesAsync();
            }

            return order;

        }


        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task? DeleteItem(int userId, int itemId)
        //{
        //    var order = await this.FindByUser(userId);
        //    if (order != null)
        //    {

        //        var itemToRemove = order.ItemOrders.Find(c => c.ItemId == itemId);

        //        if (itemToRemove != null) { order.ItemOrders.Remove(itemToRemove); }

        //    }

    }
}
