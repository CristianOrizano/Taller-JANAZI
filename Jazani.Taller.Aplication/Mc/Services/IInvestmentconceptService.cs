using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services
{
    public interface IInvestmentconceptService
    {
        Task<IReadOnlyList<InvestmentconceptDto>> FindAllAsync();
        Task<InvestmentconceptDto?> FindByIdAsync(int id);
        Task<InvestmentconceptDto> CreateAsync(InvestmentconceptSaveDto saveDto);
        Task<InvestmentconceptDto> EditAsync(int id, InvestmentconceptSaveDto saveDto);
        Task<InvestmentconceptDto> DisabledAsync(int id);

    }
}
