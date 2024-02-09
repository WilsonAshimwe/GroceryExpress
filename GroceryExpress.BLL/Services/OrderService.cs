using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using GroceryExpress.Domain.Enums;

namespace GroceryExpress.BLL.Services
{
    public class OrderService(IOrderRepository _orderRepository, IUserRepository _userRepository, IItemOrderRepository _itemOrderRepository)
    {
        public async Task<Order> Add(int userId, int delivererId)
        {
            Order order = await _orderRepository.Add(new Order 
            { 
                DelivererId = delivererId,
                UserId = userId,
                OrderDate = DateTime.Now,
            });

            //_itemOrderRepository.Add(new ItemOrder() { OrderId = order.Id});

            return order;
        }
    }
}
