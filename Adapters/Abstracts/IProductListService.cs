using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeditepeProductServiceReference;

namespace Adapters.Abstracts
{
    public interface IProductListService
    {
        public Task<List<Product>> getProductAll();
    }
}
