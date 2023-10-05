

using AutoMapper;
using Jazani.Taller.Domain.Mc.Models;

namespace Jazani.Taller.Aplication.Mc.Dtos.Auctionareas.Profiles
{
    public class AuctionareaProfile : Profile
    {
        public AuctionareaProfile()
        {
            CreateMap<Auctionarea, AuctionareaDto>();
            CreateMap<Auctionarea, AuctionareaSaveDto>().ReverseMap();

        }

    }
}
