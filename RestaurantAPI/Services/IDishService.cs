using RestaurantAPI.Models;
using System.Collections.Generic;

namespace RestaurantAPI.Services
{
    public interface IDishService
    {
        public int Create(int restaurantId, CreateDishDto dto);
        public DishDto GetById(int restaurantId, int dishId);
        public List<DishDto> GetAll(int restaurantId);
        void RemoveAll(int restaurantId);
        public void RemoveById(int restaurantId, int dishId);
        public void Edit(int restaurantId, int dishId, EditDishDto dto);
    }
}