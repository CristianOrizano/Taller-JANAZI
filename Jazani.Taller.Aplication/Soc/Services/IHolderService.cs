using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Soc.Dtos.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Soc.Services
{
    public interface IHolderService
    {
        Task<IReadOnlyList<HolderDto>> FindAllAsync();
    }
}
