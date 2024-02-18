namespace GroceryExpress.DOMAIN.Entities
{
    public class Basket
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<BasketItem> BasketItems { get; set; }

        public DateTime BasketDate { get; set; } = DateTime.Now;






    }
}
