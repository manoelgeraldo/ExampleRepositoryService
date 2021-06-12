using FoodRepositoryServiceDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Services
{
    public interface IFoodItemService
    {
        Task<List<FoodItemViewModel>> GetAllSold();
        Task<FoodItemViewModel> GetId(int id);
        Task<FoodItemViewModel> InsertItem(FoodItemViewModel item);
        Task DeleteItem(int id);
    }
}
