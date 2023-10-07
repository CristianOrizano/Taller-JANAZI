using Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits;
using Jazani.Taller.Aplication.Mc.Dtos.MiningConcessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Services
{
    public interface IMeasureUnitService
    {
        Task<IReadOnlyList<MeasureUnitDto>> FindAllAsync();
        Task<MeasureUnitDto?> FindByIdAsync(int id);
        Task<MeasureUnitDto> CreateAsync(MeasureUnitSaveDto saveDto);
        Task<MeasureUnitDto> EditAsync(int id, MeasureUnitSaveDto saveDto);
        Task<MeasureUnitDto> DisabledAsync(int id);

    }
}
