using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IBasketRepository
    {
        Task<Basket?> Find(int id);

        Task<List<Basket>> FindAll();

        Task<Basket> Add(Basket basket);

        Task<Basket> Update(Basket basket);
        Task Delete(Basket basket);

        Task DeleteItem(int id);


        Task<List<Basket>> FindAllWithItems();
        Task<Basket?> FindByUser(int userId);

        Task<Basket?> AddBasketItems(int userId, List<BasketItem> basketItems);
        Task<Basket?> RemoveBasketItems(int userId, List<BasketItem> basketItems);
    }
}
