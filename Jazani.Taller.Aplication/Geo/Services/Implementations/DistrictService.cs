using AutoMapper;
using Jazani.Taller.Aplication.Geo.Dtos.Districts;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Services;
using Jazani.Taller.Domain.Geo.Models;
using Jazani.Taller.Domain.Geo.Repositories;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Geo.Services.Implementations
{
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository _districRepository;
        private readonly IMapper _mapper;

        public DistrictService(IDistrictRepository distriRepository, IMapper mapper)
        {
            _districRepository = distriRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<DistrictDto>> FindAllAsync()
        {
            IReadOnlyList<District> distric = await _districRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<DistrictDto>>(distric);
        }

        public async Task<DistrictDto?> FindByIdAsync(string id)
        {
            District distri = await _districRepository.FindByIdAsync(id);

            return _mapper.Map<DistrictDto>(distri);
        }
    }
}
