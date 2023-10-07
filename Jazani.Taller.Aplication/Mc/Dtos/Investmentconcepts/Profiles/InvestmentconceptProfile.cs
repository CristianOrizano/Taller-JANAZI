using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts.Profiles
{
    public class InvestmentconceptProfile : Profile
    {
        public InvestmentconceptProfile()
        {
            CreateMap<Investmentconcept, InvestmentconceptDto>();
            CreateMap<Investmentconcept, InvestmentconceptSaveDto>().ReverseMap();
            CreateMap<Investmentconcept, InvestmentconceptSimpleDto>().ReverseMap();

        }
    }
}
