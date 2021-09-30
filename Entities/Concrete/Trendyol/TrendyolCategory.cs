using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Trendyol
{
    public class TrendyolCategory:IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
    }
}
