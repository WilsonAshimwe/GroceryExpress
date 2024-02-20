namespace GroceryExpress.API.DTO.Orders
{
    public class ShowOrderDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }


        public List<ShowItemOrderDTO> ItemOrders { get; set; }


        public decimal SubTotal { get => ItemOrders.Sum(io => io.Quantity * io.ItemPrice); }
        public decimal Shipping { get => SubTotal / 10; }
        public decimal Total { get => SubTotal + (SubTotal / 10); }

        public int TotalElements { get => (ItemOrders.Sum(io => io.Quantity)); }






        public DateTime BasketDate { get; set; }
    }
}
