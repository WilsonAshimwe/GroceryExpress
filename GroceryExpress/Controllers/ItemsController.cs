using AutoMapper;
using GroceryExpress.API.DTO.Items;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController(ItemService _itemService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetAll()
        {

            var users = await _itemService.GetAll();


            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetAll(int id)
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
    }
}
