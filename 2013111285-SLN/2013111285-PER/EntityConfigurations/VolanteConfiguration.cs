using _2013111285_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285_PER.EntityConfigurations
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {

        public VolanteConfiguration()
        {
            ToTable("Volante")
               .HasKey(c => c.VolanteId);
            Property(v => v.NumSerie)
                 .IsRequired()
                 .HasMaxLength(100);

        }

    }
}
