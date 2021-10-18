using Adapters;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Bebeji;
using Entities.Concrete.Hepsiburada;
using Entities.Concrete.Yeditepe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //ProductAdded();
            //CategoryAdded();
            //BrandAdded();
            //DescriptionAdded();
            var hbProductList= HbMerchantSkuData(0);
            HepsiburadaProductManager hepsiburadaProductManager = new HepsiburadaProductManager(new EfHepsiburadaProductDal());
            foreach (var product in hbProductList)
            {
                hepsiburadaProductManager.save(product);
                Console.WriteLine(product.Barcode);
            }
            Console.ReadLine();
        }

        public static List<HepsiburadaProduct> HbMerchantSkuData(int page)
        {
            var result= HbGetMerchantSku(0);
            foreach (var item in result)
            {
                Console.WriteLine(item.Barcode);
            }
            Console.ReadLine();
            return result;
        }

        private static List<HepsiburadaProduct> HbGetMerchantSku(int page)
        {
            string userName = "yeditepesoft_dev";
            string password = "rg6vzMJ!";
            XmlDocument xmlDocument = new XmlDocument();
            List<HepsiburadaProduct> listings = new List<HepsiburadaProduct>();
            Hepsiburada hb = new Hepsiburada();
            int limit = 5000;
            string TotalCount = "";
            do
            {
                var result = hb.GetXmlResult("https://listing-external.hepsiburada.com/listings/merchantid/5a2ad94b-9627-47b4-8eac-cff212a2f45c?offset=" + page.ToString() + "&limit=" + limit);
                xmlDocument.LoadXml(result.Result);
                XmlNode resultData = xmlDocument.SelectSingleNode("Result");
                TotalCount = resultData.SelectSingleNode("TotalCount").InnerText;
                XmlNode ListingsXmlList = resultData.SelectSingleNode("Listings");
                XmlNodeList ListingXmlList = ListingsXmlList.SelectNodes("Listing");
                HepsiburadaProduct listing;
                foreach (XmlNode list in ListingXmlList)
                {
                    listing = new HepsiburadaProduct();
                    listing.Barcode=list.SelectSingleNode("MerchantSku").InnerText;
                    listings.Add(listing);
                }
                page++;
                limit = Convert.ToInt32(TotalCount) - listings.Count();
            }
            while (Convert.ToInt32(TotalCount)> listings.Count());
            return listings;
        }

        private static void ProductAdded()
        {
            YeditepeProductManager yeditepeProductManager = new YeditepeProductManager(new EfYeditepeProductDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeProduct _product;
            var result = client.getProductAll();
            foreach (var item in result.Result)
            {
                _product = new YeditepeProduct();
                _product.ItemCode = item.ItemCode;
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
                Console.WriteLine(_product.ProductName + "Kaydedildi.");
            }
            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine();
        }
        private static void CategoryAdded()
        {
            YeditepeCategoryManager yeditepeCategoryManager = new YeditepeCategoryManager(new EfYeditepeCategoryDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeCategory _category;
            var result = client.getCategoryAll();
            foreach (var item in result.Result)
            {
                _category = new YeditepeCategory();
                _category.CategoryId = item.CategoryId;
                _category.CategoryName = item.CategoryName;
                _category.DisplayOrder = item.DisplayOrder;
                _category.CatalogId = item.CatalogId;
                _category.ParentId = item.ParentId;
                _category.Url = item.Url;
                yeditepeCategoryManager.save(_category);
                Console.WriteLine(_category.CategoryName + "Kaydedildi.");
            }
            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine();
        }

        private static void BrandAdded()
        {
            YeditepeBrandManager yeditepeBrandManager = new YeditepeBrandManager(new EfYeditepeBrandDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeBrand _brand;
            var result = client.getBrandAll();
            foreach (var item in result.Result)
            {
                _brand = new YeditepeBrand();
                _brand.BrandName = item.BrandName;
                _brand.IsBlocked = item.IsBlocked;
                yeditepeBrandManager.save(_brand);
                Console.WriteLine(_brand.BrandName + "Kaydedildi.");
            }
            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine();
        }
        private static void ImageAdded()
        {
            YeditepeImageManager yeditepeImageManager = new YeditepeImageManager(new EfYeditepeImageDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeProductManager yeditepeProductManager = new YeditepeProductManager(new EfYeditepeProductDal());
            YeditepeImage _image;


            var result = yeditepeProductManager.getAll();
            foreach (var item in result.Data)
            {
                client.getImageAll(item.ItemCode);
            }
            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine();
        }
        private static void DescriptionAdded()
        {
            YeditepeDescriptionManager yeditepeDescriptionManager = new YeditepeDescriptionManager(new EfYeditepeDescriptionDal());
            YeditepeProductServiceAdapter client = new YeditepeProductServiceAdapter(new YeditepeProductServiceReference.ProductApiClient());
            YeditepeDescription _description;
            var result = client.getDescriptionAll();
            foreach (var item in result.Result)
            {
                _description = new YeditepeDescription();
                _description.CreatedDate = item.CreatedDate;
                _description.CreatedUserName = item.CreatedUserName;
                _description.Description = item.Description;
                _description.ItemCode = item.ItemCode;
                _description.LastUpdatedDate = item.LastUpdatedDate;
                yeditepeDescriptionManager.save(_description);
                Console.WriteLine(_description.ItemCode + "Kaydedildi.");
            }
            Console.WriteLine("İşlem tamamlandı");
            Console.ReadLine();
        }
    }

}

