using Entities.Concrete;
using Entities.Concrete.Trendyol;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EcommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DJM0J96\SQLSERVER2017EXP;Database=Ecommerce;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Category> TrendyolCategories { get; set; }
    }
}
