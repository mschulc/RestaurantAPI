using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class EditDishDto
    {
        public string Name { get; set; }
        public string description { get; set; }
        public decimal Price { get; set; }
    }
}
