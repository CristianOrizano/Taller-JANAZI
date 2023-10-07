using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Domain.Mc.Models;
using Jazani.Taller.Domain.Soc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Soc.Dtos.Holders.Profiles
{
    public class HolderProfile : Profile
    {
        public HolderProfile()
        {
            CreateMap<Holder,HolderDto>();
            CreateMap<Holder, HolderSimpleDto>();
        }

    }
}
