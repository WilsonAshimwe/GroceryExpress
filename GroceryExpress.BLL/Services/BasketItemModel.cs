namespace GroceryExpress.BLL.Services
{
    public class BasketItemModel
    {


        public int? BasketId { get; set; }


        public int ItemId { get; set; }


        public int Quantity { get; set; } = 1;


        public decimal ItemPrice { get; set; }

    }
}
