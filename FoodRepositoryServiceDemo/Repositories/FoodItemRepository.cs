using FoodRepositoryServiceDemo.Data;
using FoodRepositoryServiceDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodRepositoryServiceDemo.Repositories
{
    public class FoodItemRepository : IFoodItemRepository
    {
        #region Context
        private readonly AppDbContext _context;

        public FoodItemRepository(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<List<FoodItem>> GetAllSold()
        {
            return await _context.FoodItems.ToListAsync();
        }
        public async Task<FoodItem> GetId(int id)
        {
            var item = await _context.FoodItems.FirstOrDefaultAsync(f => f.ID == id);
            return item;
        }
        public async Task InsertItem(FoodItem foodItem)
        {
            await _context.FoodItems.AddAsync(foodItem);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteItem(FoodItem foodItem)
        {
            _context.FoodItems.Remove(foodItem);
            await _context.SaveChangesAsync();
        }

    }
}
