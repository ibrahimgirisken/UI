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
    public class YeditepeBrandManager : IYeditepeBrandService
    {
        IYeditepeBrandDal _yeditepeBrandDal;

        public YeditepeBrandManager(IYeditepeBrandDal yeditepeBrandDal)
        {
            _yeditepeBrandDal = yeditepeBrandDal;
        }

        public IDataResult<List<YeditepeBrand>> getAll()
        {
            return new SuccessDataResult<List<YeditepeBrand>>(_yeditepeBrandDal.GetAll(), "Markalar listelendi");
        }
    }
}
