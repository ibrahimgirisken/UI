using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Trendyol
{
   public class TrendyolAttributeValue:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int AttributeValueId { get; set; }
        [MaxLength(50)]
        public string AttributeValueName { get; set; }
        public int AttributeId { get; set; }
    }
}
