using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>,    IUserRepository
    {
       

        public UserRepository(GroceryExpressContext context) : base(context)
        {
      
        }

        public async Task<User?> FindWithAddress(int id)
        {
            return await _table.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == id);    
        }
    }
}
