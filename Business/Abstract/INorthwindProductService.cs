using Core.Utilities.Results;
using Entities.Concrete.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INorthwindProductService
    {
        public IDataResult<List<NorthwindProduct>> GetAll();
        public IDataResult<List<NorthwindProduct>> GetAllByCategoryId(int categoryId);
    }
}
