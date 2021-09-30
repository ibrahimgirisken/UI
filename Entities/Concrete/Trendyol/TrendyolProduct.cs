using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Trendyol
{
    public class TrendyolProduct:IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        public string Barcode { get; set; }
    }
}
