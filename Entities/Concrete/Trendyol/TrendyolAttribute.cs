using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Trendyol
{
   public class TrendyolAttribute:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AttributeId { get; set; }
        [MaxLength(50)]
        public string AttributeName { get; set; }
        public bool AllowCustom { get; set; }
        public bool Required { get; set; }
        public bool Slicer { get; set; }
        public bool Varianter { get; set; }
    }
}
