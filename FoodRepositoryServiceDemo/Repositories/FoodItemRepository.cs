using FoodRepositoryServiceDemo.Data;
using FoodRepositoryServiceDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<FoodItem> InsertItem(FoodItem item)
        {
            await _context.FoodItems.AddAsync(item);
            await _context.SaveChangesAsync();
            
        }
        public async Task DeleteItem(int id)
        {
            var item = await _context.FoodItems.FirstOrDefaultAsync(i => i.ID == id);
            
            if(item!= null)
            {
                _context.FoodItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

    }
}
