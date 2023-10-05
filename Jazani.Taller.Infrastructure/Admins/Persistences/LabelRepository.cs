using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Cores.Context;
using Jazani.Taller.Infrastructure.Cores.Persistences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security;


namespace Jazani.Taller.Infrastructure.Admins.Persistences
{
    public class LabelRepository : CrudRepository<Label, int>, ILabelRepository
    {
        public LabelRepository(AplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
