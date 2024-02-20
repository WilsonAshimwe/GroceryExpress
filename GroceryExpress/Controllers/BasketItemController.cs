using AutoMapper;
using GroceryExpress.API.DTO.BasketItems;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/basketitems")]
    [ApiController]
    public class BasketItemController(BasketItemService _basketItemService, ItemService _itemService, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<BasketItem>>> GetAll()
        {

            var basketitems = await _basketItemService.GetAll();



            var results = mapper.Map<List<BasketItem>, List<ShowBasketItemsDTO>>(basketitems);

            return Ok(results);
        }


        [HttpPost]
        public async Task<ActionResult<BasketItem>> Add([FromBody] CreateBasketItemsDTO basketItemDTO)
        {

            Item item = await _itemService.Get(basketItemDTO.ItemId);



            BasketItem basketitem = await _basketItemService.Add(basketItemDTO.BasketId, basketItemDTO.ItemId, basketItemDTO.Quantity, item.Price);

            return Ok(mapper.Map<ShowBasketItemsDTO>(basketitem));
        }



        [HttpDelete]
        public async Task<ActionResult> Delete([FromQuery] int basketId, int itemId)
        {
            try
            {
                await _basketItemService.Delete(basketId, itemId);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }


        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateBasketItemsDTO basketItemDTO)
        {
            try
            {
                Item item = await _itemService.Get(basketItemDTO.ItemId);
                var basketitem = await _basketItemService.Update(id, basketItemDTO.BasketId, basketItemDTO.ItemId, basketItemDTO.Quantity, item.Price
                    );
                return Ok(mapper.Map<ShowBasketItemsDTO>(basketitem));

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);

            }

        }

    }
}
