using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using Jazani.Taller.Aplication.Mc.Dtos.MiningConcessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services
{
    public interface IMiningConcessionService
    {
        Task<IReadOnlyList<MiningConcessionDto>> FindAllAsync();
        Task<MiningConcessionDto?> FindByIdAsync(int id);
        Task<MiningConcessionDto> CreateAsync(MiningConcessionSaveDto saveDto);
        Task<MiningConcessionDto> EditAsync(int id, MiningConcessionSaveDto saveDto);
        Task<MiningConcessionDto> DisabledAsync(int id);

    }
}
