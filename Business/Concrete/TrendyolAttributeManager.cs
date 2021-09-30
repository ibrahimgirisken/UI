using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Trendyol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrendyolAttributeManager : ITrendyolAttributeService
    {
        ITrendyolAttributeDal _trendyolAttributeDal;

        public TrendyolAttributeManager(ITrendyolAttributeDal trendyolAttributeDal)
        {
            _trendyolAttributeDal = trendyolAttributeDal;
        }

        public List<TrendyolAttribute> GetAll()
        {
            return _trendyolAttributeDal.GetAll();
        }
    }
}
