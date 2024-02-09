using AutoMapper;
using GroceryExpress.API.DTO.Items;
using GroceryExpress.API.DTO.Users;
using GroceryExpress.BLL.Services;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController(ItemService _itemService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetAll(GroceryCategory? searchCategory, string? searchBrand, string? sortProp, bool isDescending, int page = 1)
        {


            //var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Item, ShowItemDTO>());

            var items= await _itemService.GetAll(searchCategory, searchBrand, sortProp, isDescending, page);

            return Ok(mapper.Map<List<Item>, List<ShowItemDTO>>(items));
        
        }

            [HttpGet("{id}")]
        public async Task<ActionResult<Item>> Get(int id)
        {

            try
            {
                //if(id.ToString() != User.FindFirstValue(ClaimTypes.NameIdentifier) && !User.IsInRole("ADMIN"))
                //{
                //    return Forbid();
                //}


                Item item = await _itemService.Get(id);
                return Ok(mapper.Map<Item, ShowItemDTO>(item));



            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }
        }

        [HttpPost]
        public async Task<ActionResult> Add(CreateItemDTO dto)
        {

            await _itemService.Add(
                dto.Name, dto.Description, dto.Brand, dto.Price, dto.Category, dto.ImageUrl
                );
            return Ok();
            
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _itemService.Delete(id);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }
    }
}
