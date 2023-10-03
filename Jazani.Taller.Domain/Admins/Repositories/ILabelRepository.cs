using Jazani.Taller.Domain.Admins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Admins.Repositories
{
    public interface ILabelRepository
    {
        Task<IReadOnlyList<Label>> FindAllAsync();
        Task<Label> FindByIdAsync(int id);
        Task<Label> SaveAsync(Label la);
    }
}
