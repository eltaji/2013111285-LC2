﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_ENT
{
    [Table("Buses")]
    public class Bus : Carro
    {
        [Key]
        public int busid { get; set; }
        public TipoBus TipoBus { get; set; }

        public Bus(Volante volante, Parabrisas parabrisas, int numLlantas,
                         int numAsientos, Propietario propietario, TipoCarro tipoCarro, TipoBus tipoBus)
            :base(volante, parabrisas, numLlantas, numAsientos, propietario, tipoCarro)
        {
            TipoBus = tipoBus;
        }

        public Bus()
        {

        }

    }
}