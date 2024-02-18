using GroceryExpress.BLL.Interfaces;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class ItemService(IItemRepository _itemRepository)
    {

        private const int MaxPageSize = 50;

        public async Task<Item> Add(string name, string description, string brand, decimal price, GroceryCategory category, string Image)
        {
            return await _itemRepository.Add(

                new Item()
                {
                    Name = name,
                    Description = description,
                    Price = price,
                    Brand = brand,
                    Category = category,
                    ImageUrl = Image
                });

        }

        public async Task<Item> Get(int id)
        {

            Item? item = await _itemRepository.Find(id);
            if (item == null)
            {
                throw new KeyNotFoundException($"There is no item with id {id}");
            }
            return item;
        }

        public async Task<List<Item>> GetAll(GroceryCategory? searchCategory, string? searchBrand, string? searchName, string? sortProp, bool isDescending, int page, int size)
        {
            if (size > MaxPageSize) { size = MaxPageSize; }
            return await _itemRepository.FindAll(searchCategory, searchBrand, searchName, sortProp, isDescending, page, size);

        }

        public async Task<int> Count(GroceryCategory? searchCategory, string? searchBrand)
        {
            return await _itemRepository.Count(searchCategory, searchBrand);
        }


        public async Task Delete(int id)
        {

            Item? Item = await _itemRepository.Find(id);
            if (Item == null)
            {
                throw new KeyNotFoundException($"There is no Item with id {id}");
            }
            await _itemRepository.Delete(Item);



        }

        public async Task<Item> Update(int id, string name, string description, string brand, decimal price, GroceryCategory category, string imageUrl)
        {

            Item? item = await _itemRepository.Find(id);
            if (item is null)
            {
                throw new KeyNotFoundException($"the item with {id} cannot be found");
            };

            item.Name = name;
            item.Description = description;
            item.Brand = brand;
            item.Price = price;
            item.Category = category;
            item.ImageUrl = imageUrl;

            return await _itemRepository.Update(item);

        }


    }
}
