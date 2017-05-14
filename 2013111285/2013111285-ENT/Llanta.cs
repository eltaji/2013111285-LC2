using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_ENT
{
    [Table("Llantas")]

    public class Llanta
    {
        [Key]
        public int llantaid { get; set; }
        public string NumSerie { get; set; }
    }
}
