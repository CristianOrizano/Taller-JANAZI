using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security;


namespace Jazani.Taller.Infrastructure.Admins.Persistences
{
    public class LabelRepository : ILabelRepository
    {
        private readonly AplicationDbContext _dbContext;

        public LabelRepository(AplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  async Task<IReadOnlyList<Label>> FindAllAsync()
        {
            return await _dbContext.Labels.ToListAsync();
        }

        public async Task<Label> FindByIdAsync(int id)
        {
            return await _dbContext.Labels
               .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Label> SaveAsync(Label label)
        {
            EntityState state = _dbContext.Entry(label).State;

            _ = state switch
            {
                EntityState.Detached => _dbContext.Labels.Add(label),
                EntityState.Modified => _dbContext.Labels.Update(label)
            };

            await _dbContext.SaveChangesAsync();

            return label;
        }
    }
}
