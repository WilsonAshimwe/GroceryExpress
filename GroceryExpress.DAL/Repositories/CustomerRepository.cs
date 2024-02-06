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
    public class CustomerRepository : BaseRepository<Customer>,    ICustomerRepository
    {
        public CustomerRepository(GroceryExpressContext context) : base(context)
        {
        }
    }
}
