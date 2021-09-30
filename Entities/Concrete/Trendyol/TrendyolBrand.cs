using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Trendyol
{
    public class TrendyolBrand:IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public int BrandId { get; set; }
        [MaxLength(100)]
        public string BrandName { get; set; }
    }
}
