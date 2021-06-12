using FoodRepositoryServiceDemo.Services;
using FoodRepositoryServiceDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Controllers
{
    public class FoodItemController : Controller
    {
        private readonly IFoodItemService _foodItemService;

        public FoodItemController(IFoodItemService foodItemService)
        {
            _foodItemService = foodItemService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var itemsSold = await _foodItemService.GetAllSold();
            return View(itemsSold);
        }

        [HttpGet]
        public async Task<IActionResult> InsertItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertItem(FoodItemViewModel foodItemVM)
        {
            if (ModelState.IsValid)
            {
                await _foodItemService.InsertItem(foodItemVM);
                return View("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _foodItemService.GetId(id);
            return View(item);
        }
    }
}
