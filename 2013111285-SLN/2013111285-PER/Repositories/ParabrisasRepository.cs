using _2013111285_ENT.Entities;
using _2013111285_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111285_PER.Repositories
{
    public class ParabrisasRepository : Repository<Parabrisas>, IParabrisasRepository
    {
        public ParabrisasRepository(EnsambladoraDbContext context) : base(context)
        {
       
        }

    }
}
