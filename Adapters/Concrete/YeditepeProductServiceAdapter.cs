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

        public async Task<List<Product>> getProductAll()
        {
            var result= _productApi.ProductListAsync("tr", "bebeji@123");
            return await result;
        }
        public async Task<List<Category>> getCategoryAll()
        {
            var result = _productApi.CategoryListAsync("tr", "bebeji@123");
            return await result;
        }
        public async Task<List<Brand>> getBrandAll()
        {
            var result = _productApi.BrandListAsync("tr", "bebeji@123");
            return await result;
        }
        public async Task<List<ItemDetailDesc>> getDescriptionAll()
        {
            var result = _productApi.ProductDescriptionListAsync("tr", "bebeji@123");
            return await result;
        }
        public async Task<List<Images>> getImageAll(string ItemCode)
        {
            var result = _productApi.ImageListAsync(ItemCode, "bebeji@123");
            return await result;
        }
    }
}
