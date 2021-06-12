using FoodRepositoryServiceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Repositories
{
    public interface IFoodItemRepository
    {
        Task<List<FoodItem>> GetAllSold ();
        Task<FoodItem> GetId(int id);
        Task<FoodItem> InsertItem (FoodItem item);
        Task DeleteItem (int id);
    }
}
