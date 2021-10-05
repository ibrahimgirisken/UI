using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BebejiProductManager : IBebejiProductService
    {
        IBebejiProductDal _productDal;

        public BebejiProductManager(IBebejiProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<BebejiProduct>> GetAll()
        {
            return new SuccessDataResult<List<BebejiProduct>>(_productDal.GetAll());
        }
    }
}
