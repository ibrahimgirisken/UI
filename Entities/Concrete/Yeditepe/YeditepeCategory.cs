using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Yeditepe
{
    public class YeditepeCategory:IEntity
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public int ParentId { get; set; }
    }
}
