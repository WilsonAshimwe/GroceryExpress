using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using GroceryExpress.Domain.Enums;

namespace GroceryExpress.BLL.Services
{
    public class OrderService(IOrderRepository _orderRepository, IUserRepository _userRepository, IItemRepository _itemRepository)
    {
        public async Task<Order> Add(int userId, List<ItemOrder> itemOrders)
        {
            foreach (var itemOrder in itemOrders)
            {

                Item item = await _itemRepository.Find(itemOrder.ItemId) ?? throw new Exception();
                itemOrder.ItemPrice = item.Price;
            }

            Order order = await _orderRepository.Add(new Order
            {
                UserId = userId,
                ItemOrders = itemOrders

            });
            return order;
        }
        public async Task<List<Order>> GetAll()
        {
            return await _orderRepository.FindAllWithItems();
        }

        public async Task<Order> Get(int id)
        {
            Order? order = await _orderRepository.Find(id);
            if (order == null)
            {
                throw new KeyNotFoundException($"There is not order with id {id}");
            }
            return order;
        }
    }
}
