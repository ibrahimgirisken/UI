using Core.Utilities.Results;
using Entities.Concrete.Trendyol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITrendyolAttributeService
    {
        List<TrendyolAttribute> GetAll();
        IResult Add(TrendyolAttribute trendyolAttribute);
    }
}
