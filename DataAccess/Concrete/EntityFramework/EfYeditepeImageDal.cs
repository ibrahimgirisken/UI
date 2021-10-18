using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Yeditepe;;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfYeditepeImageDal:EfEntityRepositoryBase<YeditepeImage,EcommerceContext>,IYeditepeImageDal
    {
    }
}
