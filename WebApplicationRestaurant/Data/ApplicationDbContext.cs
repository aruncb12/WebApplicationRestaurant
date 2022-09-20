using Microsoft.EntityFrameworkCore;
using WebApplicationRestaurant.Models;

namespace WebApplicationRestaurant.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<WebApplicationRestaurant.Models.Customer> Customer { get; set; }
    }
}
