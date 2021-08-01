using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Authorization
{
    public class CreatedMulipleRestaurantRequirement : IAuthorizationRequirement
    {
        public CreatedMulipleRestaurantRequirement(int minimumRestaurantCreated )
        {
            MinimumRestaurantsCreated = minimumRestaurantCreated;
        }
        public int MinimumRestaurantsCreated { get;  }
    }
}
