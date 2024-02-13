﻿using GroceryExpress.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations;

namespace GroceryExpress.API.DTO.Orders
{
    public class CreateOrderDTO
    {
        public int UserId { get; set; }
        [Required]
        public ICollection<CreateItemOrderDTO> itemOrders { get; set; }

    }
}
