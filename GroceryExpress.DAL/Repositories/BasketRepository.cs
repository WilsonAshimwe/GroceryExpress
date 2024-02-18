using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public class BasketRepository : BaseRepository<Basket>, IBasketRepository
    {
        private readonly GroceryExpressContext _context;

        public BasketRepository(GroceryExpressContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Basket>> FindAllWithItems()
        {
            return await _table.Include(o => o.BasketItems).ThenInclude(io => io.Item).ToListAsync();
        }

        public async Task<Basket?> FindByUser(int userId)
        {
            var basket = await _table.Include(o => o.BasketItems).ThenInclude(io => io.Item).Where(b => b.UserId == userId).FirstOrDefaultAsync();
            return basket;
        }
        public async Task<Basket?> AddBasketItems(int userId, List<BasketItem> basketItems)
        {
            var basket = await _table.Include(o => o.BasketItems).ThenInclude(io => io.Item).Where(b => b.UserId == userId).FirstOrDefaultAsync();

            if (basket != null)
            {
                for (int i = 0; i < basketItems.Count; i++)
                {

                    basket.BasketItems.Add(basketItems[i]);
                }

                await _context.SaveChangesAsync();
            }

            return basket;

        }

        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task? DeleteItem(int userId, int itemId)
        //{
        //    var basket = await this.FindByUser(userId);
        //    if (basket != null)
        //    {

        //        var itemToRemove = basket.BasketItems.Find(c => c.ItemId == itemId);

        //        if (itemToRemove != null) { basket.BasketItems.Remove(itemToRemove); }

        //    }




    }

}

