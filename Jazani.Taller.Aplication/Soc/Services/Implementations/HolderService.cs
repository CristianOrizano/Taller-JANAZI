using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Services;
using Jazani.Taller.Aplication.Soc.Dtos.Holders;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using Jazani.Taller.Domain.Soc.Models;
using Jazani.Taller.Domain.Soc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Soc.Services.Implementations
{
    public class HolderService : IHolderService
    {
        private readonly IHolderRepository _holderRepository;
        private readonly IMapper _mapper;

        public HolderService(IHolderRepository holderRepository, IMapper mapper)
        {
            _holderRepository = holderRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<HolderDto>> FindAllAsync()
        {
            IReadOnlyList<Holder> holer = await _holderRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<HolderDto>>(holer);
        }
    }
}
