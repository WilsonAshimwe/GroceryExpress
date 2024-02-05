using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryExpress.DOMAIN.Entities
{
    public class ShopItem
    {

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public int Price { get; set; }
    }
}
