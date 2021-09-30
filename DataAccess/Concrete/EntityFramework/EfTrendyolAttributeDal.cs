using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Trendyol;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTrendyolAttributeDal:EfEntityRepositoryBase<TrendyolAttribute, EcommerceContext>,ITrendyolAttributeDal
    {
    }
}
