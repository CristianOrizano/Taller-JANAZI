using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Aplication.Mc.Dtos.Investments;
using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services.Implemetations
{
    public class InvestmentService: IInvestmentService
    {
        private readonly IInvestmentRepository _invesmepeRepository;
        private readonly IMapper _mapper;

        public InvestmentService(IInvestmentRepository invespeRepository, IMapper mapper)
        {
            _invesmepeRepository = invespeRepository;
            _mapper = mapper;
        }

        public async Task<InvestmentDto> CreateAsync(InvestmentSaveDto saveDto)
        {
            Investment invesme = _mapper.Map<Investment>(saveDto);
            invesme.RegistrationDate = DateTime.Now;
            invesme.State = true;

            Investment invesmeSaved = await _invesmepeRepository.SaveAsync(invesme);
            return _mapper.Map<InvestmentDto>(invesmeSaved);
        }

        public async Task<InvestmentDto> DisabledAsync(int id)
        {
            Investment invesme = await _invesmepeRepository.FindByIdAsync(id);
            invesme.State = false;

            Investment auctionSaved = await _invesmepeRepository.SaveAsync(invesme);

            return _mapper.Map<InvestmentDto>(auctionSaved);
        }

        public async Task<InvestmentDto> EditAsync(int id, InvestmentSaveDto saveDto)
        {
            Investment invesme = await _invesmepeRepository.FindByIdAsync(id);

            _mapper.Map<InvestmentSaveDto, Investment>(saveDto, invesme);

            Investment invesmSaved = await _invesmepeRepository.SaveAsync(invesme);

            return _mapper.Map<InvestmentDto>(invesmSaved);
        }

        public async Task<IReadOnlyList<InvestmentDto>> FindAllAsync()
        {
            IReadOnlyList<Investment> invesme = await _invesmepeRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<InvestmentDto>>(invesme);
        }

        public async Task<InvestmentDto?> FindByIdAsync(int id)
        {
            Investment invesm = await _invesmepeRepository.FindByIdAsync(id);

            return _mapper.Map<InvestmentDto>(invesm);
        }
    }
}
