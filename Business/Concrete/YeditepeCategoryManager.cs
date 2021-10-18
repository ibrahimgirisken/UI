using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class YeditepeCategoryManager : IYeditepeCategoryService
    {
        IYeditepeCategoryDal _yeditepeCategoryDal;

        public YeditepeCategoryManager(IYeditepeCategoryDal yeditepeCategoryDal)
        {
            _yeditepeCategoryDal = yeditepeCategoryDal;
        }

        public IDataResult<List<YeditepeCategory>> getAll()
        {
            return new SuccessDataResult<List<YeditepeCategory>>(_yeditepeCategoryDal.GetAll(),"Ürünler listelendi");
        }

        public void save(YeditepeCategory category)
        {
            _yeditepeCategoryDal.Add(category);
        }
    }
}
