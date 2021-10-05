using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ITrendyolAttributeService service = new TrendyolAttributeManager(new EfTrendyolAttributeDal());
            foreach (var attribute in service.GetAll().Data)
            {
                Console.WriteLine("Özellik Adı : "+attribute.AttributeName + " Kategori Adı : " + attribute.CategoryId + " Zorunlu : " + attribute.Required);
            }
            Console.ReadLine();
            //BebejiProductList();
        }

        private static void BebejiProductList()
        {
            IBebejiProductService productManager = new BebejiProductManager(new EfBebejiProductDal());
            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
