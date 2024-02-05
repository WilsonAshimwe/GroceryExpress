using GroceryExpress.Domain.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DOMAIN.Utils
{
    public class CategoryConverter : ValueConverter<GroceryCategory, string>
    {
        public CategoryConverter():base(
            v => v.ToString(), v =>!string.IsNullOrWhiteSpace(v)? 
            (GroceryCategory)Enum.Parse(typeof(GroceryCategory), v): GroceryCategory.Other)
        {
        }
    }
}
