using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface ICustomerRepository
    {
        Customer? Find(int id);
        ICollection<Customer> FindAll();

       Customer Add(Customer customer);

       void Update(Customer customer);
       void Delete(Customer customer);




    }
}
