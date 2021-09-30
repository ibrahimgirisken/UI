using Business.Abstract;
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

        public List<BebejiProduct> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
