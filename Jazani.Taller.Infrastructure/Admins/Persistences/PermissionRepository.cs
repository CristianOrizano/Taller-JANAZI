using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Taller.Infrastructure.Admins.Persistences
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly AplicationDbContext _dbContext;

        public PermissionRepository(AplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<Permission>> FindAllAsync()
        {
            return await _dbContext.Permissions.ToListAsync();
        }

        public async Task<Permission> FindByIdAsync(int id)
        {
            return await _dbContext.Permissions
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Permission> SaveAsync(Permission permission)
        {
            EntityState state = _dbContext.Entry(permission).State;

            _ = state switch
            {
                EntityState.Detached => _dbContext.Permissions.Add(permission),
                EntityState.Modified => _dbContext.Permissions.Update(permission)
            };

            await _dbContext.SaveChangesAsync();

            return permission;
        }
    }
}

