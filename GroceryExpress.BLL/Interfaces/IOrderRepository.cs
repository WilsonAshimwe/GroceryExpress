using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IOrderRepository
    {
        Order? Find(int id);
        ICollection<Order> FindAll();

        Order Add(Order Order);

        void Update(Order Order);
        void Delete(Order Order);
    }
}
