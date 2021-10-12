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
    public class NorthwindProductManager : INorthwindProductService
    {
        INorthwindProductDal _nortwindProductDal;

        public NorthwindProductManager(INorthwindProductDal nortwindProductDal)
        {
            _nortwindProductDal = nortwindProductDal;
        }

        public IDataResult<List<NorthwindProduct>> GetAll()
        {
           return new SuccessDataResult<List<NorthwindProduct>>(_nortwindProductDal.GetAll(),"Ürünler listelendi");
        }

        public IDataResult<List<NorthwindProduct>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<NorthwindProduct>>(_nortwindProductDal.GetAll(p=>p.CategoryId==categoryId), "Kategoriye göre ürünler listelendi");
        }
    }
}