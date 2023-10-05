using Jazani.Taller.Aplication.Geo.Dtos.Districts;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Geo.Services
{
    public interface IDistrictService
    {
        Task<IReadOnlyList<DistrictDto>> FindAllAsync();
        Task<DistrictDto?> FindByIdAsync(string id);
    }
}
