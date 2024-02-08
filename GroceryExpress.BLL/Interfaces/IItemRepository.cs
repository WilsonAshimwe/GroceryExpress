using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IItemRepository
    {

        Task<Item?> Find(int id);

        Task<List<Item>> FindAll();

        Task<Item> Add(Item Item);

        Task<Item> Update(Item Item);
        Task Delete(Item Item);
    }
}
