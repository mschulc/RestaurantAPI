using RestaurantAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "KFC is American fast food restaurant chain.",
                    ContactEmail = "contact@kfc.com",
                    HasDelivery = false,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Kubełek Mały",
                            Price = 10.99M,
                        },
                        new Dish()
                        {
                            Name = "Kubełek Duży",
                            Price = 19.99M,
                        },
                        new Dish()
                        {
                            Name = "Longer",
                            Price = 4.99M,
                        }
                    },
                    Address = new Address()
                    {
                        City = "Gdańsk",
                        Street = "Bulońska 10",
                        PostalCode = "80-224"
                    }
                },
                new Restaurant()
                {
                    Name = "ChoNoTu Burgery",
                    Category = "American Burgers",
                    Description = "Small private restaurants with burgers",
                    ContactEmail = "chonotu@burgery.com",
                    ContactNumber = "321-312-123",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Burger Gdański",
                            Price = 24.00M,
                        },
                        new Dish()
                        {
                            Name = "Burger Hamburg",
                            Price = 21.00M,
                        },
                        new Dish()
                        {
                            Name = "Frytki",
                            Price = 10.00M,
                        }
                    },
                    Address = new Address()
                    {
                        City = "Gdańsk",
                        Street = "Wilanowska",
                        PostalCode = "80-190"
                    }
                },
                new Restaurant()
                {
                    Name = "U Koguta",
                    Category = "Pizza",
                    Description = "Small polish pizzeria with all kinds of pizza and beer.",
                    ContactEmail = "ukoguta@gamil.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Margaritta",
                            Price = 19.99M,
                        },
                        new Dish()
                        {
                            Name = "Hawajska",
                            Price = 23.79M,
                        },
                        new Dish()
                        {
                            Name = "Diavola",
                            Price = 25.60M,
                        }
                    },
                    Address = new Address()
                    {
                        City = "Gdańsk",
                        Street = "Piotrkowsa 54",
                        PostalCode = "80-180"
                    }
                }
            };

            return restaurants;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Roles.Any())
                {
                    var roles = GetRoles();
                    _dbContext.Roles.AddRange(roles);
                    _dbContext.SaveChanges();
                }
                if(!_dbContext.Restaurants.Any())
                {
                    var restauransts = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restauransts);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role(){Name = "User" },
                new Role(){Name = "Menager" },
                new Role(){Name = "Admin" },
            };

            return roles;
        }
    }
}
