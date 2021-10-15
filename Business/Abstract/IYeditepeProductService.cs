using Core.Utilities.Results;
using Entities.Concrete.Bebeji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeditepeProductServiceReference;

namespace Business.Abstract
{
    public interface IYeditepeProductService
    {
        IDataResult<List<YeditepeProduct>> getAll();
        IDataResult<List<YeditepeProduct>> GetAllByCategoryId(int categoryId);
        void save(YeditepeProduct product);
    }
}
