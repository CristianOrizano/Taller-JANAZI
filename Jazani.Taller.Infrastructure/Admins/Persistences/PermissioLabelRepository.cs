using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Admins.Persistences
{
    public class PermissioLabelRepository : CrudRepository<PermissionLabel, int>, IPermissionLabelRepository
    {
        public PermissioLabelRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
