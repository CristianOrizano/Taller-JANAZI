using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Mc.Persistences
{
    public class InvestmenttypeRepository : CrudRepository<Investmenttype, int>, IInvestmenttypeRepository
    {
        public InvestmenttypeRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
