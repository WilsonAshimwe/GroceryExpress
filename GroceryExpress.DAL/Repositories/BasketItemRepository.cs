using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public class BasketItemRepository : BaseRepository<BasketItem>, IBasketItemRepository
    {
        public BasketItemRepository(GroceryExpressContext context) : base(context)
        {


        }

        public async Task<BasketItem?> Find(int basketId, int ItemId)
        {
            return await _table.Where(i => (i.BasketId == basketId && i.ItemId == ItemId)).FirstOrDefaultAsync();
        }
    }
}
