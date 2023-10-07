using AutoMapper;
using Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Domain.Ge.Models;
using Jazani.Taller.Domain.Ge.Repositories;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Services.Implementations
{
    public class MeasureUnitService : IMeasureUnitService
    {
        private readonly IMeasureUnitRepository _measuRepository;
        private readonly IMapper _mapper;

        public MeasureUnitService(IMeasureUnitRepository auctRepository, IMapper mapper)
        {
            _measuRepository = auctRepository;
            _mapper = mapper;
        }

        public async Task<MeasureUnitDto> CreateAsync(MeasureUnitSaveDto saveDto)
        {
            MeasureUnit measu = _mapper.Map<MeasureUnit>(saveDto);
            measu.RegistrationDate = DateTime.Now;
            measu.State = true;

            MeasureUnit autiomSaved = await _measuRepository.SaveAsync(measu);
            return _mapper.Map<MeasureUnitDto>(autiomSaved);
        }

        public async Task<MeasureUnitDto> DisabledAsync(int id)
        {
            MeasureUnit measure = await _measuRepository.FindByIdAsync(id);
            measure.State = false;

            MeasureUnit auctionSaved = await _measuRepository.SaveAsync(measure);

            return _mapper.Map<MeasureUnitDto>(auctionSaved);
        }

        public async Task<MeasureUnitDto> EditAsync(int id, MeasureUnitSaveDto saveDto)
        {
            MeasureUnit measure = await _measuRepository.FindByIdAsync(id);

            _mapper.Map<MeasureUnitSaveDto, MeasureUnit>(saveDto, measure);

            MeasureUnit auctionSaved = await _measuRepository.SaveAsync(measure);

            return _mapper.Map<MeasureUnitDto>(auctionSaved);
        }

        public async Task<IReadOnlyList<MeasureUnitDto>> FindAllAsync()
        {
            IReadOnlyList<MeasureUnit> measure = await _measuRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<MeasureUnitDto>>(measure);
        }

        public async Task<MeasureUnitDto?> FindByIdAsync(int id)
        {
            MeasureUnit measure = await _measuRepository.FindByIdAsync(id);

            return _mapper.Map<MeasureUnitDto>(measure);
        }
    }
}
