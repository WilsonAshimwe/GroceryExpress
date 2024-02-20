using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> Find(int id);

        Task<List<Order>> FindAll();

        Task<Order> Add(Order order);

        Task<Order> Update(Order order);
        Task Delete(Order order);

        Task DeleteItem(int id);


        Task<List<Order>> FindAllWithItems();
        Task<Order?> FindByUser(int userId);

        Task<Order?> AddItemOrders(int userId, List<ItemOrder> itemOrders);
        Task<Order?> RemoveItemOrders(int userId, List<ItemOrder> itemOrders);

        Task<Order?> FindById(int orderId);

    }
}
