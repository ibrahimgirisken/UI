using Entities.Concrete;
using Entities.Concrete.Trendyol;
using Microsoft.EntityFrameworkCore;
using TrendyolProduct = Entities.Concrete.Trendyol.TrendyolProduct;

namespace DataAccess.Concrete.EntityFramework
{
    public class EcommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DJM0J96\SQLSERVER2017EXP;Database=Ecommerce;Trusted_Connection=true");
        }
        public DbSet<BebejiDescription> BebejiDescriptions { get; set; }
        public DbSet<TrendyolCategory> TrendyolCategories { get; set; }
        public DbSet<TrendyolBrand> TrendyolBrands { get; set; }
        public DbSet<TrendyolAttribute> TrendyolAttributes { get; set; }
        public DbSet<TrendyolAttributeValue> TrendyolAttributesValue { get; set; }
        public DbSet<TrendyolProduct> TrendyolProducts { get; set; }
    }
}
