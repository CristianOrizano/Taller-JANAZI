using AutoMapper;
using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Mc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Services.Implemetations
{
    public class AuctionareaService : IAuctionareaService
    {
        private readonly IAuctionareaRepository _auctiRepository;
        private readonly IMapper _mapper;

        public AuctionareaService(IAuctionareaRepository auctRepository, IMapper mapper)
        {
            _auctiRepository = auctRepository;
            _mapper = mapper;
        }

        public async Task<AuctionareaDto> CreateAsync(AuctionareaSaveDto saveDto)
        {
            Auctionarea auctio = _mapper.Map<Auctionarea>(saveDto);
            auctio.RegistrationDate = DateTime.Now;
            auctio.State = true;

            Auctionarea autiomSaved = await _auctiRepository.SaveAsync(auctio);
            return _mapper.Map<AuctionareaDto>(autiomSaved);
        }

        public async Task<AuctionareaDto> DisabledAsync(int id)
        {
            Auctionarea auction = await _auctiRepository.FindByIdAsync(id);
            auction.State = false;

            Auctionarea auctionSaved = await _auctiRepository.SaveAsync(auction);

            return _mapper.Map<AuctionareaDto>(auctionSaved);
        }

        public async Task<AuctionareaDto> EditAsync(int id, AuctionareaSaveDto saveDto)
        {
            Auctionarea auctiona = await _auctiRepository.FindByIdAsync(id);

            _mapper.Map<AuctionareaSaveDto, Auctionarea>(saveDto, auctiona);

            Auctionarea auctionSaved = await _auctiRepository.SaveAsync(auctiona);

            return _mapper.Map<AuctionareaDto>(auctionSaved);
        }

        public async Task<IReadOnlyList<AuctionareaDto>> FindAllAsync()
        {
            IReadOnlyList<Auctionarea> auction = await _auctiRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<AuctionareaDto>>(auction);
        }

        public async Task<AuctionareaDto?> FindByIdAsync(int id)
        {
            Auctionarea auctio = await _auctiRepository.FindByIdAsync(id);
            
            return _mapper.Map<AuctionareaDto>(auctio);
        }
    }
}
