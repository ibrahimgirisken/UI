using Entities.Concrete.Bebeji;
using Entities.Concrete.Hepsiburada;
using Entities.Concrete.Northwind;
using Entities.Concrete.Yeditepe;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EcommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DJM0J96\SQLSERVER2017EXP;Database=Ecommerce;Trusted_Connection=true");
        }
        public DbSet<YeditepeCategory> YeditepeCategories { get; set; }
        public DbSet<YeditepeProduct> YeditepeProducts { get; set; }
        public DbSet<YeditepeBrand> YeditepeBrands { get; set; }
        public DbSet<YeditepeDescription> YeditepeDescriptions { get; set; }
        public DbSet<HepsiburadaProduct> HepsiburadaProducts { get; set; }

    }
}
