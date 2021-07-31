using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class DishDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public decimal Price { get; set; }
    }
}
