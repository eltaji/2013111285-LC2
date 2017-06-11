using _2013111285_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285_PER.EntityConfigurations
{
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            ToTable("Cinturones")
                  .HasKey(c => c.CinturonId);
            Property(v => v.NumSerie)
                 .IsRequired()
                 .HasMaxLength(100);
            Property(v => v.Metraje)
                 .IsRequired();


        }

    }
}
