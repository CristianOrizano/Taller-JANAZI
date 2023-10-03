using Jazani.Taller.Aplication.Admins.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Services
{
    public interface IPermissionService
    {
        Task<IReadOnlyList<PermissionDto>> FindAllAsync();
        Task<PermissionDto> FindByIdAsync(int id);
        Task<PermissionDto> CreateAsync(PermissionSaveDto permisSaveDto);
        Task<PermissionDto> EditAsync(int id, PermissionSaveDto permisSaveDto);
        Task<PermissionDto> DisabledAsync(int id);

    }
}
