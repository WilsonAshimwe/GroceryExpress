using AutoMapper;
using GroceryExpress.API.DTO.Orders;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Security.Claims;

namespace GroceryExpress.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController(OrderService _orderService, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Order>> Add([FromBody] CreateOrderDTO dto)
        {
         
            Order order = await _orderService.Add(dto.UserId, dto.itemOrders.Select(i => _mapper.Map<ItemOrder>(i)).ToList());

            return Created("", _mapper.Map<OrderDTO>(order));

        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {

            var orders = await _orderService.GetAll();
            return Ok(_mapper.Map<List<ShowOrderDTO>>(orders));

        }        
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            try
            {
            var order = await _orderService.Get(id);
            return Ok(_mapper.Map<ShowOrderDTO>(order));

            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest();
                
            }


        }
    }
}


