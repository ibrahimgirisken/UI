using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Yeditepe
{
    public class YeditepeBrand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public bool IsBlocked { get; set; }
    }
}
