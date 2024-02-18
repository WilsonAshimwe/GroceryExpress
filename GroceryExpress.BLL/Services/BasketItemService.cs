using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class BasketItemService(IBasketItemRepository _basketitemRepository)
    {
        public async Task<BasketItem> Add(int basketId, int itemId, int quantity, decimal itemPrice)
        {
            return await _basketitemRepository.Add(

                new BasketItem()
                {
                    BasketId = basketId,
                    ItemId = itemId,
                    Quantity = quantity,
                    ItemPrice = itemPrice

                });

        }
        public async Task<BasketItem> Get(int id)
        {

            BasketItem? basketitem = await _basketitemRepository.Find(id);
            if (basketitem == null)
            {
                throw new KeyNotFoundException($"There is no basketitem with id {id}");
            }
            return basketitem;
        }

        public async Task<List<BasketItem>> GetAll()
        {
            return await _basketitemRepository.FindAll();

        }

        public async Task Delete(int id)
        {

            BasketItem? BasketItem = await _basketitemRepository.Find(id);
            if (BasketItem == null)
            {
                throw new KeyNotFoundException($"There is no BasketItem with id {id}");
            }
            await _basketitemRepository.Delete(BasketItem);

        }

        public async Task<BasketItem> Update(int id, int basketId, int itemId, int quantity, decimal itemPrice)
        {

            BasketItem? basketitem = await _basketitemRepository.Find(id);
            if (basketitem is null)
            {
                throw new KeyNotFoundException($"the basketitem with {id} cannot be found");
            };

            basketitem.BasketId = basketId;
            basketitem.ItemId = itemId;
            basketitem.Quantity = quantity;
            basketitem.ItemPrice = itemPrice;

            return await _basketitemRepository.Update(basketitem);
        }

    }
}
