using Core.Utilities.Results;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYeditepeDescriptionService
    {
        IDataResult<List<YeditepeDescription>> getAll();
        void save(YeditepeDescription description);
    }
}
