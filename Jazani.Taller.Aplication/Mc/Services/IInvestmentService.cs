using Jazani.Taller.Aplication.Mc.Dtos.Investments;
using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services
{
    public interface IInvestmentService
    {
        Task<IReadOnlyList<InvestmentDto>> FindAllAsync();
        Task<InvestmentDto?> FindByIdAsync(int id);
        Task<InvestmentDto> CreateAsync(InvestmentSaveDto saveDto);
        Task<InvestmentDto> EditAsync(int id, InvestmentSaveDto saveDto);
        Task<InvestmentDto> DisabledAsync(int id);
    }
}
