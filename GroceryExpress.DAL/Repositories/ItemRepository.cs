using GroceryExpress.BLL.Interfaces;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GroceryExpress.DAL.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(GroceryExpressContext context) : base(context)
        {
      
        }

        public async Task<List<Item>> FindAll(GroceryCategory? searchCategory, string? searchBrand, string? sortProp, bool isDescending, int page = 1)
        {
            var subQuery = _table
                .Where(i => searchCategory == null || i.Category == searchCategory)
                .Where(i => searchBrand == null || i.Brand == searchBrand);
            if(sortProp != null)
            {
                subQuery = isDescending
                    ? subQuery.OrderByDescending(i => sortProp ==  "name" ? i.Name : (sortProp == "Category" ? i.Brand : i.Name))
                    : subQuery.OrderBy(i => sortProp == "name" ? i.Name : (sortProp == "Category" ? i.Brand : i.Name));
            }
            subQuery.Skip((page - 1) * 10).Take(10);
            return await subQuery.ToListAsync();
        }
    }
}
