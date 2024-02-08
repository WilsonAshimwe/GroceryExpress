using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> Find(int id);
        Task<User?> FindWithAddress(int id);

        Task<User?> FindWithOrders(int id);

        Task<List<User>> FindAll();

        Task<User> Add(User user);

        Task<User> Update(User user);
        Task Delete(User user);




    }
}
