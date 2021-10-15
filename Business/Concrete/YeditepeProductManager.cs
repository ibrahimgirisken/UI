using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.Bebeji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeditepeProductServiceReference;

namespace Business.Concrete
{
    public class  YeditepeProductManager : IYeditepeProductService
    {
        IYeditepeProductDal _yeditepeProductDal;

        public YeditepeProductManager(IYeditepeProductDal yeditepeProductDal)
        {
            _yeditepeProductDal = yeditepeProductDal;
        }

        public IDataResult<List<YeditepeProduct>> getAll()
        {
            return new SuccessDataResult<List<YeditepeProduct>>(_yeditepeProductDal.GetAll(), "Ürünler listelendi");
        }

        public IDataResult<List<YeditepeProduct>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<YeditepeProduct>>(_yeditepeProductDal.GetAll(p=>p.CategoryId==categoryId), "Ürünler listelendi");
        }

        public void save(YeditepeProduct product)
        {
            _yeditepeProductDal.Add(product);
        }
    }
}
