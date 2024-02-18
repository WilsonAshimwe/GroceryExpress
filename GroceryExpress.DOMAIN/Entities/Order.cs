﻿namespace GroceryExpress.DOMAIN.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<ItemOrder> ItemOrders { get; set; } = new List<ItemOrder>();


        public DateTime OrderDate { get; set; } = DateTime.Now;












    }
}
