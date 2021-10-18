using Core.Utilities.Results;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYeditepeCategoryService
    {
        IDataResult<List<YeditepeCategory>> getAll();
        void save(YeditepeCategory category);
    }
}
