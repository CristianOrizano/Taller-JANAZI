using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.Investments.Profiles
{
    public class InvestmentProfile: Profile
    {
        public InvestmentProfile()
        {
            CreateMap<Investment, InvestmentDto>();
            CreateMap<Investment, InvestmentSaveDto>().ReverseMap();

        }
    }
}
