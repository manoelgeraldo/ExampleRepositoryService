using FoodRepositoryServiceDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodRepositoryServiceDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .Property(f => f.SalePrice)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<FoodItem>()
                .Property(f => f.UnitPrice)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Ticket>()
                .Property(f => f.SalePrice)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Ticket>()
                .Property(f => f.StudioCutPercentage)
                .HasColumnType("decimal(18,2)");
        }

        public DbSet<FoodRepositoryServiceDemo.ViewModels.FoodItemViewModel> FoodItemViewModel { get; set; }
    }
}
