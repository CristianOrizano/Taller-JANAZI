using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.Investmenttypes.Profiles
{
    public class InvestmenttypeProfile : Profile
    {
        public InvestmenttypeProfile()
        {
            CreateMap<Investmenttype, InvestmenttypeDto>();
            CreateMap<Investmenttype, InvestmenttypeSaveDto>().ReverseMap();
            CreateMap<Investmenttype, InvestmenttypeSimpleDto>().ReverseMap();
        }

    }
}
