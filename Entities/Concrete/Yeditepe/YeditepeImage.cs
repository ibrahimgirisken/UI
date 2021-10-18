using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Yeditepe
{
    public class YeditepeImage:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ImageId { get; set; }
        public string ImageId2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
    }
}
