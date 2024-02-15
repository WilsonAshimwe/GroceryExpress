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
    public class LoginRepository : BaseRepository<User>, ILoginRepository
    {
        public LoginRepository(GroceryExpressContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmail(string email)
        {
            return await _table.Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User?> GetByUsername(string username)
        {
            return await _table.Where(u => u.Username == username).FirstOrDefaultAsync();
        }
    }
}
