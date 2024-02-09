using GroceryExpress.BLL.Interfaces;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace GroceryExpress.BLL.Services
{
    public class ItemService(IItemRepository _itemRepository)
    {

        public async Task<Item> Add(string name, string description, string brand,  decimal price, GroceryCategory category, string Image)
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
                throw new KeyNotFoundException($"There is not item with id {id}");
            }
            return item;
        }

        public async Task<List<Item>> GetAll(GroceryCategory? searchCategory, string? searchBrand, string? sortProp, bool isDescending, int page)
        {
            return await  _itemRepository.FindAll(searchCategory, searchBrand, sortProp, isDescending, page);
          
        }


        public async Task Delete(int id)
        {

            Item? Item = await _itemRepository.Find(id);
            if (Item == null)
            {
                throw new KeyNotFoundException($"There is not Item with id {id}");
            }
            await _itemRepository.Delete(Item);



        }


    }
}
