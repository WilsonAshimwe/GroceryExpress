namespace GroceryExpress.API.DTO.Baskets
{
    public class CreateBasketItemDTO
    {
        public int ItemId { get; set; }


        public int Quantity { get; set; } = 1;
    }
}
