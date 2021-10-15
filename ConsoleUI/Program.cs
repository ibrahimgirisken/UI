using Adapters;
using Adapters.Abstracts;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Bebeji;
using System;
using YeditepeProductServiceReference;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            YeditepeProductManager yeditepeProductManager = new YeditepeProductManager(new EfYeditepeProductDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeProduct _product;
            var result = client.getAll();
            foreach (var item in result.Result)
            {
                _product = new YeditepeProduct();
                _product.Barcode = item.Barcode;
                _product.Brand = item.Brand;
                _product.CategoryId = item.CategoryId;
                _product.CurrencyCode = item.CurrencyCode;
                _product.ErpCode = item.ErpCode;
                _product.GrossQty = item.GrossQty;
                _product.Price1 = item.Price1;
                _product.Price3 = item.Price3;
                _product.ProcurumentProcess = item.ProcurementProcess;
                _product.ProductId = item.ProductId;
                _product.ProductName = item.ItemDescription;
                _product.ShippingVolume = item.ShippingVolume;
                _product.Status = item.Status;
                _product.Tax = item.Tax;
                _product.Url = item.Url;
                yeditepeProductManager.save(_product);
                Console.WriteLine(_product.ProductName +"Kaydedildi.");
            }

            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine(); 
        }

    }
}
