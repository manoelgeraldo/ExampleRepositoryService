using FoodRepositoryServiceDemo.Services;
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

        public IActionResult Index()
        {
            var itemsSold = _foodItemService.GetAllSold();
            return View(itemsSold);
        }
    }
}
