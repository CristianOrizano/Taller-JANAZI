using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services.Implemetations
{
    public class InvestmentconceptService : IInvestmentconceptService
    {
        private readonly IInvestmentconceptRepository  _investRepository;
        private readonly IMapper _mapper;

        public InvestmentconceptService(IInvestmentconceptRepository invesRepository, IMapper mapper)
        {
            _investRepository = invesRepository;
            _mapper = mapper;
        }

        public async Task<InvestmentconceptDto> CreateAsync(InvestmentconceptSaveDto saveDto)
        {
            Investmentconcept invesme = _mapper.Map<Investmentconcept>(saveDto);
            invesme.RegistrationDate = DateTime.Now;
            invesme.State = true;

            Investmentconcept invesmeSaved = await _investRepository.SaveAsync(invesme);
            return _mapper.Map<InvestmentconceptDto>(invesmeSaved);
        }

        public async Task<InvestmentconceptDto> DisabledAsync(int id)
        {
            Investmentconcept invesme = await _investRepository.FindByIdAsync(id);
            invesme.State = false;

            Investmentconcept auctionSaved = await _investRepository.SaveAsync(invesme);

            return _mapper.Map<InvestmentconceptDto>(auctionSaved);
        }

        public async Task<InvestmentconceptDto> EditAsync(int id, InvestmentconceptSaveDto saveDto)
        {
            Investmentconcept invesme = await _investRepository.FindByIdAsync(id);

            _mapper.Map<InvestmentconceptSaveDto, Investmentconcept>(saveDto, invesme);

            Investmentconcept invesmSaved = await _investRepository.SaveAsync(invesme);

            return _mapper.Map<InvestmentconceptDto>(invesmSaved);
        }

        public async Task<IReadOnlyList<InvestmentconceptDto>> FindAllAsync()
        {
            IReadOnlyList<Investmentconcept> invesme = await _investRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<InvestmentconceptDto>>(invesme);
        }

        public async Task<InvestmentconceptDto?> FindByIdAsync(int id)
        {
            Investmentconcept invesm = await _investRepository.FindByIdAsync(id);

            return _mapper.Map<InvestmentconceptDto>(invesm);
        }
    }
}
