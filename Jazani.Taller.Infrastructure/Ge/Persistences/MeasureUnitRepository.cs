using Jazani.Taller.Domain.Ge.Models;
using Jazani.Taller.Domain.Ge.Repositories;
using Jazani.Taller.Domain.Soc.Models;
using Jazani.Taller.Domain.Soc.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Ge.Persistences
{
    public class MeasureUnitRepository : CrudRepository<MeasureUnit, int>, IMeasureUnitRepository
    {
        public MeasureUnitRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}
