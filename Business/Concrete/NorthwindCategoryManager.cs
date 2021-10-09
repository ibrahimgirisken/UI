using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NorthwindCategoryManager : INorthwindCategoryService
    {
        INorthwindCategoryDal _northwindCategoryDal;

        public NorthwindCategoryManager(INorthwindCategoryDal northwindCategoryDal)
        {
            _northwindCategoryDal = northwindCategoryDal;
        }

        public IDataResult<List<NorthwindCategory>> GetAll()
        {
            return new SuccessDataResult<List<NorthwindCategory>>(_northwindCategoryDal.GetAll(),"Kategoriler listelendi");
        }
    }
}
