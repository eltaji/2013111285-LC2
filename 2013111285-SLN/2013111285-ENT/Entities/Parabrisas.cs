﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285_ENT.Entities
{
    public class Parabrisas
    {
        public int ParabrisasId { get; set; }
        public string NumSerie { get; set; }



        public Carro Carro { get; set; }

        public Parabrisas()
        {

        }
    }
       
}
