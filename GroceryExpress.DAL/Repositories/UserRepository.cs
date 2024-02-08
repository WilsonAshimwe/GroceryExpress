using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {


        public UserRepository(GroceryExpressContext context) : base(context)
        {

        }

        public async Task<User?> FindWithAddress(int id)
        {
            return await _table.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<User?> FindWithOrders(int id)
        {
            return await _table.Include(c => c.Orders).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
