using _2013132285_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013132285_PER.Migrations
{
    public class AsientoConfiguration:EntityTypeConfiguration<Asiento>
    {

        public AsientoConfiguration()
        {
            ToTable("Asientos");
            HasKey(c =>c.asientoid);
        }
    }
}
