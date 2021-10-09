using Entities.Concrete.Northwind;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DJM0J96\SQLSERVER2017EXP;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<NorthwindProduct> Products { get; set; }
        public DbSet<NorthwindCategory> Categories { get; set; }
    }
}
