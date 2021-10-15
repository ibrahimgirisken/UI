using Adapters.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeditepeProductServiceReference;

namespace Adapters
{
    public class YeditepeProductServiceAdapter : IProductListService
    {
        IProductApi _productApi;

        public YeditepeProductServiceAdapter(IProductApi productApi)
        {
            _productApi = productApi;
        }

        public async Task<List<Product>> getAll()
        {
            var result= _productApi.ProductListAsync("tr", "bebeji@123");
            return await result;
        }
    }
}
