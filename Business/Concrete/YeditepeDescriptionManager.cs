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
    public class YeditepeDescriptionManager : IYeditepeDescriptionService
    {
        IYeditepeDescriptionDal _yeditepeDescriptionDal;

        public YeditepeDescriptionManager(IYeditepeDescriptionDal yeditepeDescriptionDal)
        {
            _yeditepeDescriptionDal = yeditepeDescriptionDal;
        }

        public IDataResult<List<YeditepeDescription>> getAll()
        {
            return new SuccessDataResult<List<YeditepeDescription>>(_yeditepeDescriptionDal.GetAll(), "Açıklamalar listelendi");
        }
    }
}
