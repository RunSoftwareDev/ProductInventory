using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "Vanilla Ice Cream",
                    Inventory = 13,
                    Price = 7.50,
                },
                 new Product
                 {
                     ProductID = 2,
                     ProductName = "Mango Ice Cream",
                     Inventory = 7,
                     Price = 8.15,
                 },
                  new Product
                  {
                      ProductID = 3,
                      ProductName = "Strawberry Ice Cream",
                      Inventory = 20,
                      Price = 8.00,
                  },
                   new Product
                   {
                       ProductID = 4,
                       ProductName = "Chocolate Ice Cream",
                       Inventory = 20,
                       Price = 8.50,
                   },
                    new Product
                    {
                        ProductID = 5,
                        ProductName = "Peanut Butter Ice Cream",
                        Inventory = 8,
                        Price = 8.75,
                    }
                );
        }
    }
}
