using Jazani.Taller.Aplication.Admins.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Services
{
    public interface ILabelService
    {
        Task<IReadOnlyList<LabelDto>> FindAllAsync();
        Task<LabelDto> FindByIdAsync(int id);
        Task<LabelDto> CreateAsync(LabelSaveDto labelSaveDto);
        Task<LabelDto> EditAsync(int id, LabelSaveDto labelSaveDto);
        Task<LabelDto> DisabledAsync(int id);
    }
}
