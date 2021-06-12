using FoodRepositoryServiceDemo.Repositories;
using FoodRepositoryServiceDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public async Task<List<FoodItemViewModel>> GetAllSold()
        {
            var item = await _foodIntemRepository.GetAllSold();

            return item.Select(item => new FoodItemViewModel
            {
                ID = item.ID,
                Name = item.Name,
                SalePrice = item.SalePrice,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity

            }).ToList();
        }

        public async Task<FoodItemViewModel> GetId(int id)
        {
            var item = await _foodIntemRepository.GetId(id);

            if (item == null)
                return null;
            
            return new FoodItemViewModel
            {
                ID = item.ID,
                Name = item.Name,
                SalePrice = item.SalePrice,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity
            };

        }

        public async Task<FoodItemViewModel> InsertItem(FoodItemViewModel NewItem)
        {
            var Item = new FoodItemViewModel
            {
                ID = NewItem.ID,
                Name = NewItem.Name,
                SalePrice = NewItem.SalePrice,
                UnitPrice = NewItem.UnitPrice,
                Quantity = NewItem.Quantity
            };
            
            return Item;
        }

        public async Task DeleteItem(int id)
        {
            var item = await _foodIntemRepository.GetId(id);

            await _foodIntemRepository.DeleteItem(id);
        }

    }
}
