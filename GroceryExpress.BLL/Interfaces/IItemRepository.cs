using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Interfaces
{
    public interface IItemRepository
    {

        Task<Item?> Find(int id);

        Task<List<Item>> FindAll(GroceryCategory? searchCategory, string? searchBrand, string? sortProp, bool isDescending, int page, int size);

        Task<Item> Add(Item Item);

        Task<Item> Update(Item Item);
        Task Delete(Item Item);
        Task<int> Count(GroceryCategory? searchCategory, string? searchBrand);
    }
}
