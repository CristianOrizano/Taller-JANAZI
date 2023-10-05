﻿using Jazani.Taller.Domain.Cores.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Cores.Persistences
{
    public abstract class CrudRepository<T, ID> : ICrudRepository<T, ID> where T : class
    {
        private readonly AplicationDbContext _dbContext;
        protected CrudRepository(AplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<T>> FindAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> FindByIdAsync(ID id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> SaveAsync(T entity)
        {
            EntityState state = _dbContext.Entry(entity).State;

            _ = state switch
            {
                EntityState.Detached => _dbContext.Set<T>().Add(entity),
                EntityState.Modified => _dbContext.Set<T>().Update(entity)

            };

            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}