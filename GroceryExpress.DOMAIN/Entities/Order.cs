namespace GroceryExpress.DOMAIN.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Item> Items { get; set; }


        public int DelivererId { get; set; }

        public Deliverer Deliverer { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Order()
        {
            Items = new HashSet<Item>();
        }










    }
}
