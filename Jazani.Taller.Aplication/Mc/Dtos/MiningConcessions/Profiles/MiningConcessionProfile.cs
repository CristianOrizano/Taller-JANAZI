using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.MiningConcessions.Profiles
{
    public class MiningConcessionProfile : Profile
    {
        public MiningConcessionProfile()
        {
            CreateMap<MiningConcession, MiningConcessionDto>();
            CreateMap<MiningConcession, MiningConcessionSaveDto>().ReverseMap();
            CreateMap<MiningConcession, MiningConcessionSimpleDto>().ReverseMap();

        }
    }
}
