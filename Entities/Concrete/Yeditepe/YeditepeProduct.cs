using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Bebeji
{
    public class YeditepeProduct : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string ErpCode { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Price3 { get; set; }
        public decimal Price1 { get; set; }
        public byte Tax { get; set; }
        public int GrossQty { get; set; }
        public short Status { get; set; }
        public string ProcurumentProcess { get; set; }
        public double ShippingVolume { get; set; }
        public string Url { get; set; }

    }
}
