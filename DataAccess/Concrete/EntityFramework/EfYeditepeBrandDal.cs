using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfYeditepeBrandDal:EfEntityRepositoryBase<YeditepeBrand,EcommerceContext>,IYeditepeBrandDal
    {
    }
}
