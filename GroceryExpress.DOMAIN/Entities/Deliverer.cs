using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DOMAIN.Entities
{
    public class Deliverer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string VehicleType { get; set; } = null!; 

        public string City { get; set; } = null!;
    }
}
