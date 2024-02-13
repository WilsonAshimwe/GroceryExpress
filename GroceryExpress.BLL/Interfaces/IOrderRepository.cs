using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> Find(int id);
        Task<List<Order>> FindAll();

        Task<Order> Add(Order Order);

        Task<Order> Update(Order Order);
        Task Delete(Order Order);
        Task<List<Order>> FindAllWithItems();
    }
}
