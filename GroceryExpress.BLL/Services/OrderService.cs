using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

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


            Order? order = await _orderRepository.FindByUser(userId);
            if (order == null)
            {
                Order newOrder = await _orderRepository.Add(new Order
                {
                    UserId = userId,
                    ItemOrders = itemOrders

                });
                order = newOrder;
            }
            else
            {
                order = await _orderRepository.AddItemOrders(userId, itemOrders);


            };

            return order;

        }
        public async Task<Order> RemoveItems(int userId, List<ItemOrder> itemOrders)
        {

            var order = await _orderRepository.RemoveItemOrders(userId, itemOrders);
            if (order == null)
            {
                throw new KeyNotFoundException($"There is no order for userid {userId}");
            }
            else { return order; }


        }

        public async Task Delete(int id)
        {

            Order? order = await _orderRepository.Find(id);
            if (order == null)
            {
                throw new KeyNotFoundException($"There is no order with id {id}");
            }
            await _orderRepository.Delete(order);



        }




        public async Task<List<Order>> GetAllWithItems()
        {
            return await _orderRepository.FindAllWithItems();
        }

        public async Task<Order?> FindByUser(int id)

        {
            User? user = await _userRepository.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            return await _orderRepository.FindByUser(id);
        }

        public async Task<List<Order>> GetAll()
        {
            return await _orderRepository.FindAll();
        }

        public async Task<Order> Get(int id)
        {
            Order? order = await _orderRepository.Find(id);
            if (order == null)
            {
                throw new KeyNotFoundException($"There is no order with id {id}");
            }
            return order;
        }

        public async Task<Order> Update(int userId, List<ItemOrder> itemOrders)
        {

            Order? Order = await _orderRepository.FindByUser(userId);
            if (Order is null)
            {
                throw new KeyNotFoundException($"the Order with {userId} cannot be found");
            };

            Order.ItemOrders = itemOrders;

            return await _orderRepository.Update(Order);

        }
    }
}
