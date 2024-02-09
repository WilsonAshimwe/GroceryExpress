using GroceryExpress.API.DTO.Orders;
using GroceryExpress.BLL.Services;
using GroceryExpress.DOMAIN.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace GroceryExpress.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class OrderController(OrderService _orderService) : ControllerBase
    //{
        //[HttpPost]
        //[Authorize]
        //public Task<ActionResult<Order>> Add([FromBody] CreateOrderDTO dto)
        //{
        //    int userId = 1;
        //    Order order = _orderService.Add(userId, dto.DelivererId);

        //    //return Created("", order);

        //}
    //}
//
}
