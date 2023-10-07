using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Mc.Persistences
{
    public class InvestmentRepository : CrudRepository<Investment, int>, IInvestmentRepository
    {
        private readonly AplicationDbContext _dbContext;
        public InvestmentRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<IReadOnlyList<Investment>> FindAllAsync()
        {
            return await _dbContext.Set<Investment>()
               .Include(i => i.Investmentconcept).Include(i => i.Investmenttype) 
               .Include(i => i.MeasureUnit).Include(i => i.PeriodType) 
               .AsNoTracking()
               .ToListAsync();
        }
        public override async Task<Investment> FindByIdAsync(int id)
        {
            return await _dbContext.Set<Investment>()
                .Include(i => i.Investmentconcept).Include(i => i.Investmenttype)
               .Include(i => i.MeasureUnit).Include(i => i.PeriodType)
               .FirstOrDefaultAsync(t => t.Id == id);
        }



    }
}
