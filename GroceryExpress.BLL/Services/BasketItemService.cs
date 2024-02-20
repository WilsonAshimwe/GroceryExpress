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
        public async Task<BasketItem> Get(int basketId, int itemId)
        {

            BasketItem? basketItem = await _basketitemRepository.Find(basketId, itemId);
            if (basketItem == null)
            {
                throw new KeyNotFoundException($"There is no basketitem with basketId {basketId} and itemId {itemId}");
            }
            return basketItem;
        }

        public async Task<List<BasketItem>> GetAll()
        {
            return await _basketitemRepository.FindAll();

        }

        public async Task Delete(int basketId, int itemId)
        {

            BasketItem? basketItem = await _basketitemRepository.Find(basketId, itemId);
            if (basketItem == null)
            {
                throw new KeyNotFoundException($"There is no basketitem with basketId {basketId} and itemId {itemId}");
            }
            await _basketitemRepository.Delete(basketItem);

        }

        public async Task<BasketItem> Update(int id, int basketId, int itemId, int quantity, decimal itemPrice)
        {

            BasketItem? basketItem = await _basketitemRepository.Find(basketId, itemId);
            if (basketItem == null)
            {
                throw new KeyNotFoundException($"There is no basketitem with basketId {basketId} and itemId {itemId}");
            }

            basketItem.BasketId = basketId;
            basketItem.ItemId = itemId;
            basketItem.Quantity = quantity;
            basketItem.ItemPrice = itemPrice;

            return await _basketitemRepository.Update(basketItem);
        }

    }
}
