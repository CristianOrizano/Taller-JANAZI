using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Taller.Infrastructure.Admins.Persistences
{
    public class PermissionRepository : CrudRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

