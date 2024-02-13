namespace GroceryExpress.DOMAIN.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<ItemOrder> ItemOrders { get; set; }


        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Order()
        {
            ItemOrders = new HashSet<ItemOrder>();
        }










    }
}
