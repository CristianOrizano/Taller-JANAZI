using AutoMapper;
using Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits;
using Jazani.Taller.Aplication.Ge.Dtos.PeriodTypes;
using Jazani.Taller.Domain.Ge.Models;
using Jazani.Taller.Domain.Ge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Services.Implementations
{
    public class PeriodTypeService : IPeriodTypeService
    {
        private readonly IPeriodTypeRepository _periodRepository;
        private readonly IMapper _mapper;

        public PeriodTypeService(IPeriodTypeRepository periodRepository, IMapper mapper)
        {
            _periodRepository = periodRepository;
            _mapper = mapper;
        }

        public async Task<PeriodTypeDto> CreateAsync(PeriodTypeSaveDto saveDto)
        {
            PeriodType period = _mapper.Map<PeriodType>(saveDto);
            period.RegistrationDate = DateTime.Now;
            period.State = true;

            PeriodType perioSaved = await _periodRepository.SaveAsync(period);
            return _mapper.Map<PeriodTypeDto>(perioSaved);
        }

        public async Task<PeriodTypeDto> DisabledAsync(int id)
        {
            PeriodType period = await _periodRepository.FindByIdAsync(id);
            period.State = false;

            PeriodType perioSaved = await _periodRepository.SaveAsync(period);

            return _mapper.Map<PeriodTypeDto>(perioSaved);
        }

        public async Task<PeriodTypeDto> EditAsync(int id, PeriodTypeSaveDto saveDto)
        {
            PeriodType period = await _periodRepository.FindByIdAsync(id);

            _mapper.Map<PeriodTypeSaveDto, PeriodType>(saveDto, period);

            PeriodType perioSaved = await _periodRepository.SaveAsync(period);

            return _mapper.Map<PeriodTypeDto>(perioSaved);
        }

        public async Task<IReadOnlyList<PeriodTypeDto>> FindAllAsync()
        {
            IReadOnlyList<PeriodType> period = await _periodRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<PeriodTypeDto>>(period);
        }

        public async Task<PeriodTypeDto?> FindByIdAsync(int id)
        {
            PeriodType period = await _periodRepository.FindByIdAsync(id);

            return _mapper.Map<PeriodTypeDto>(period);

        }
    }
}
