using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BebejiProduct:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ItemCode { get; set; }
        public string ErpCode { get; set; }
        public string ColorCode { get; set; }
        public string ProductName { get; set; }
        public int ProductStatus { get; set; }
        public int ProcurementProcess { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price3 { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public string StockCode { get; set; }
        public int Tax { get; set; }
        public string Url { get; set; }
        public bool Success { get; set; }
        public string CurrencyType { get; set; }
        public int ShippingVolume { get; set; }
    }
}
