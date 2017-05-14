using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_ENT
{
    [Table("Asientos")]
    public class Asiento
    {
          [Key]
        public int asientoid { get; set; }
        public Cinturon Cinturon { get; set; }
        public string NumSerie { get; set; }

        public Asiento()
        {
            Cinturon = new Cinturon();
        }
    }
}
