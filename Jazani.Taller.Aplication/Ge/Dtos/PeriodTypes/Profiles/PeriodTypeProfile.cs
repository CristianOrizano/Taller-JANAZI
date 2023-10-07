using AutoMapper;
using Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits;
using Jazani.Taller.Domain.Ge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Dtos.PeriodTypes.Profiles
{
    public class PeriodTypeProfile : Profile
    {
        public PeriodTypeProfile()
        {
            CreateMap<PeriodType, PeriodTypeDto>();
            CreateMap<PeriodType, PeriodTypeSaveDto>().ReverseMap();
            CreateMap<PeriodType, PeriodTypeSimpleDto>().ReverseMap();
        }
    }
}
