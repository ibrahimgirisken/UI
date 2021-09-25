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
        public DbSet<Product> BebejiProducts { get; set; }
        public DbSet<Description> BebejiDescriptions { get; set; }
        public DbSet<Category> TrendyolCategories { get; set; }
        public DbSet<Brand> TrendyolBrands { get; set; }
        public DbSet<Attribute> TrendyolAttributes { get; set; }
        public DbSet<AttributeValue> TrendyolAttributesValue { get; set; }
    }
}
