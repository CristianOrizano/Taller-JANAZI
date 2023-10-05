using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Dtos.PermissionLabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Services
{
    public interface IPermissionLabelService
    {
        Task<IReadOnlyList<PermissionLabelDto>> FindAllAsync();
    }
}
