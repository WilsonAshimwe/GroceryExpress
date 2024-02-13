using GroceryExpress.BLL.Interfaces;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {


        public ItemRepository(GroceryExpressContext context) : base(context)
        {

        }

        public async Task<List<Item>> FindAll(GroceryCategory? searchCategory, string? searchBrand, string? sortProp, bool isDescending, int page, int size)
        {
            var subQuery = _table
                .Where(i => searchCategory == null || i.Category == searchCategory)
                .Where(i => searchBrand == null || i.Brand == searchBrand);
            if (sortProp != null)
            {
                subQuery = isDescending
                    ? subQuery.OrderByDescending(i => sortProp == "name" ? i.Name : (sortProp == "Category" ? i.Brand : i.Name))
                    : subQuery.OrderBy(i => sortProp == "name" ? i.Name : (sortProp == "Category" ? i.Brand : i.Name));
            }
            subQuery = subQuery.Skip((page - 1) * size).Take(size);
            return await subQuery.ToListAsync();
        }

        public async Task<int> Count(GroceryCategory? searchCategory, string? searchBrand)
        {
            return await _table
                .Where(i => searchCategory == null || i.Category == searchCategory)
                .Where(i => searchBrand == null || i.Brand == searchBrand).CountAsync();
            
        }
    }
}
