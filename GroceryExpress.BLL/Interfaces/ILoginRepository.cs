using GroceryExpress.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.BLL.Interfaces
{
    public interface ILoginRepository
    {
        Task<User?> GetByUsername(string username);
        Task<User?> GetByEmail(string email);
    }
}
