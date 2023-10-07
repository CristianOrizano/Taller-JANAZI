using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using Jazani.Taller.Domain.Soc.Models;
using Jazani.Taller.Domain.Soc.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Soc.Persistences
{
    public class HolderRepository : CrudRepository<Holder, int>, IHolderRepository
    {
        public HolderRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
