using Business.Abstract;
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

        public List<NorthwindProduct> GetAll()
        {
           return _nortwindProductDal.GetAll();
        }
    }
}