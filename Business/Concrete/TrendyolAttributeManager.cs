using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(TrendyolAttribute trendyolAttribute)
        {
            _trendyolAttributeDal.Add(trendyolAttribute);
            return new SuccessResult("Özellik eklendi");
        }

        public List<TrendyolAttribute> GetAll()
        {
            return _trendyolAttributeDal.GetAll();
        }
    }
}
