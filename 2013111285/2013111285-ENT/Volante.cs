using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_ENT
{
    [Table("Volantes")]
    public class Volante
    {
        [Key]
        public int volanteid { get; set; }
        public string NumSerie { get; set; }
    }
}
