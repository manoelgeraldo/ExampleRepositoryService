using FoodRepositoryServiceDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Repositories
{
    public interface IFoodItemRepository
    {
        Task<List<FoodItem>> GetAllSold();
        Task<FoodItem> GetId(int id);
        Task InsertItem(FoodItem foodItem);
        Task DeleteItem(FoodItem foodItem);
    }
}
