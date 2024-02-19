using AutoMapper;
using GroceryExpress.API.DTO.Baskets;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroceryExpress.API.Controllers
{
    [Route("api/baskets")]
    [ApiController]
    public class BasketController(BasketService _basketService, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Basket>> Add([FromBody] CreateBasketDTO dto)
        {

            Basket basket = await _basketService.Add(dto.UserId, dto.basketItems.Select(i => _mapper.Map<BasketItem>(i)).ToList());

            return Created("", _mapper.Map<BasketDTO>(basket));

        }

        [HttpPut("basketitems")]
        public async Task<ActionResult<Basket>> Remove([FromBody] CreateBasketDTO dto)
        {

            Basket basket = await _basketService.RemoveItems(dto.UserId, dto.basketItems.Select(i => _mapper.Map<BasketItem>(i)).ToList());

            return Created("", _mapper.Map<BasketDTO>(basket));

        }

        [HttpGet]
        public async Task<ActionResult<List<Basket>>> GetBaskets()
        {

            var baskets = await _basketService.GetAll();
            return Ok(_mapper.Map<List<ShowBasketDTO>>(baskets));

        }

        [HttpGet("user")]
        public async Task<ActionResult<Basket>> GetUserBasket([FromQuery] int id)
        {

            var basket = await _basketService.FindByUser(id);
            return Ok(_mapper.Map<ShowBasketDTO>(basket));

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Basket>> Get(int id)
        {
            try
            {
                var basket = await _basketService.Get(id);
                return Ok(_mapper.Map<ShowBasketDTO>(basket));

            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest();

            }


        }
    }
}
