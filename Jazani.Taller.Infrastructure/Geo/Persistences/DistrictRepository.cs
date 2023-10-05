using Jazani.Taller.Domain.Geo.Models;
using Jazani.Taller.Domain.Geo.Repositories;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Geo.Persistences
{
    public class DistrictRepository : CrudRepository<District, string>, IDistrictRepository
    {
        public DistrictRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
