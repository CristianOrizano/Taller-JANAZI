using Jazani.Taller.Domain.Admins.Repositories;
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
    public class AuctionareaRepository : CrudRepository<Auctionarea, int>,IAuctionareaRepository
    {
        public AuctionareaRepository(AplicationDbContext dbContext) : base(dbContext)
        {

        }
    }

}
