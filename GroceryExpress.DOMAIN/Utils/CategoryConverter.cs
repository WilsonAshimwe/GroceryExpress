using GroceryExpress.Domain.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryExpress.DOMAIN.Utils
{
    public class CategoryConverter : ValueConverter<GroceryCategory, string>
    {
        public CategoryConverter() : base(
            v => v.ToString(), v => !string.IsNullOrWhiteSpace(v) ?
            (GroceryCategory)Enum.Parse(typeof(GroceryCategory), v) : GroceryCategory.Other)
        {
        }
    }
}
