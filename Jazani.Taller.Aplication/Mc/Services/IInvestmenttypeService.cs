using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services
{
    public interface IInvestmenttypeService
    {
        Task<IReadOnlyList<InvestmenttypeDto>> FindAllAsync();
        Task<InvestmenttypeDto?> FindByIdAsync(int id);
        Task<InvestmenttypeDto> CreateAsync(InvestmenttypeSaveDto saveDto);
        Task<InvestmenttypeDto> EditAsync(int id, InvestmenttypeSaveDto saveDto);
        Task<InvestmenttypeDto> DisabledAsync(int id);

    }
}
