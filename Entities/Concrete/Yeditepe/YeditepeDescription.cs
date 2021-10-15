using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Yeditepe
{
    public class YeditepeDescription:IEntity
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string CreatedUserName { get; set; }
        public string Description { get; set; }
    }
}
