using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class BasketService(IBasketRepository _basketRepository, IUserRepository _userRepository, IItemRepository _itemRepository)
    {
        public async Task<Basket> Add(int userId, List<BasketItem> basketItems)
        {

            foreach (var basketItem in basketItems)
            {

                Item item = await _itemRepository.Find(basketItem.ItemId) ?? throw new Exception();
                basketItem.ItemPrice = item.Price;
            }


            Basket? basket = await _basketRepository.FindByUser(userId);
            if (basket == null)
            {
                Basket newbasket = await _basketRepository.Add(new Basket
                {
                    UserId = userId,
                    BasketItems = basketItems

                });
                basket = newbasket;
            }
            else
            {
                basket = await _basketRepository.AddBasketItems(userId, basketItems);


            };

            return basket;

        }
        public async Task<Basket> RemoveItems(int userId, List<BasketItem> basketItems)
        {

            var basket = await _basketRepository.RemoveBasketItems(userId, basketItems);
            if (basket == null)
            {
                throw new KeyNotFoundException($"There is no basket for userid {userId}");
            }
            else { return basket; }


        }

        public async Task Delete(int id)
        {

            Basket? basket = await _basketRepository.Find(id);
            if (basket == null)
            {
                throw new KeyNotFoundException($"There is no basket with id {id}");
            }
            await _basketRepository.Delete(basket);



        }




        public async Task<List<Basket>> GetAllWithItems()
        {
            return await _basketRepository.FindAllWithItems();
        }

        public async Task<Basket?> FindByUser(int id)

        {
            User? user = await _userRepository.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            return await _basketRepository.FindByUser(id);
        }

        public async Task<List<Basket>> GetAll()
        {
            return await _basketRepository.FindAll();
        }

        public async Task<Basket> Get(int id)
        {
            Basket? basket = await _basketRepository.Find(id);
            if (basket == null)
            {
                throw new KeyNotFoundException($"There is no basket with id {id}");
            }
            return basket;
        }

        public async Task<Basket> Update(int userId, List<BasketItem> basketItems)
        {

            Basket? Basket = await _basketRepository.FindByUser(userId);
            if (Basket is null)
            {
                throw new KeyNotFoundException($"the Basket with {userId} cannot be found");
            };

            Basket.BasketItems = basketItems;

            return await _basketRepository.Update(Basket);

        }
    }
}

