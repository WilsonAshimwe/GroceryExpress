using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.DAL.Repositories
{
    public class BasketItemRepository : BaseRepository<BasketItem>, IBasketItemRepository
    {
        public BasketItemRepository(GroceryExpressContext context) : base(context)
        {
        }
    }
}
