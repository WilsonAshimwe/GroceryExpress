namespace GroceryExpress.API.DTO.BasketItems
{
    public class CreateBasketItemsDTO
    {
        public int BasketId { get; set; }


        public int ItemId { get; set; }


        public int Quantity { get; set; } = 1;


        // public decimal ItemPrice { get; set; }
    }
}
