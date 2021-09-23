using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Decription:IEntity
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public Guid Guid { get; set; }
        public string CreateUserName { get; set; }
        public string LangCode { get; set; }
        public string Type { get; set; }
    }
}
