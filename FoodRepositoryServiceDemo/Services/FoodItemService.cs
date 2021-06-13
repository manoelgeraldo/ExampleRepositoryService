using FoodRepositoryServiceDemo.Models;
using FoodRepositoryServiceDemo.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Services
{
    public class FoodItemService : IFoodItemService
    {
        #region Context
        private readonly IFoodItemRepository _foodIntemRepository;

        public FoodItemService(IFoodItemRepository foodIntemRepository)
        {
            _foodIntemRepository = foodIntemRepository;
        }
        #endregion

        public async Task<List<FoodItem>> GetAllSold()
        {
            return await _foodIntemRepository.GetAllSold();
        }

        public async Task<FoodItem> GetId(int id)
        {
            return await _foodIntemRepository.GetId(id);
        }

        public async Task InsertItem(FoodItem foodItem)
        {
            await _foodIntemRepository.InsertItem(foodItem);
        }
        public async Task DeleteItem(FoodItem foodItem)
        {
            await _foodIntemRepository.DeleteItem(foodItem);
        }
    }
}
