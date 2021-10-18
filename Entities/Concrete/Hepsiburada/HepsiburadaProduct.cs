using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Hepsiburada
{
    public class HepsiburadaProduct:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Barcode { get; set; }
    }
}
