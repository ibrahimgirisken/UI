using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Hepsiburada;

namespace Business.Concrete
{
    public class HepsiburadaProductManager : IHepsiburadaProductService
    {
        IHepsiburadaProductDal _hepsiburadaProductDal;

        public HepsiburadaProductManager(IHepsiburadaProductDal hepsiburadaProductDal)
        {
            _hepsiburadaProductDal = hepsiburadaProductDal;
        }

        public void save(HepsiburadaProduct hepsiburadaProduct)
        {
            _hepsiburadaProductDal.Add(hepsiburadaProduct);
        }
    }
}
