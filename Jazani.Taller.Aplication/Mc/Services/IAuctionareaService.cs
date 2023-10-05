using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services
{
    public interface IAuctionareaService
    {
        Task<IReadOnlyList<AuctionareaDto>> FindAllAsync();
        Task<AuctionareaDto?> FindByIdAsync(int id);
        Task<AuctionareaDto> CreateAsync(AuctionareaSaveDto saveDto);
        Task<AuctionareaDto> EditAsync(int id, AuctionareaSaveDto saveDto);
        Task<AuctionareaDto> DisabledAsync(int id);
    }
}
