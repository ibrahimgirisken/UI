using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class YeditepeImageManager : IYeditepeImageService
    {
        IYeditepeImageDal _yeditepeImageDal;

        public YeditepeImageManager(IYeditepeImageDal yeditepeImageDal)
        {
            _yeditepeImageDal = yeditepeImageDal;
        }

        public void save(YeditepeImage yeditepeImage)
        {
            _yeditepeImageDal.Add(yeditepeImage);
        }
    }
}
