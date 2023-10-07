using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.MiningConcessions;
using Jazani.Taller.Domain.Ge.Models;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits.Profiles
{
    public class MeasureUnitProfile: Profile
    {
        public MeasureUnitProfile()
        {
            CreateMap<MeasureUnit, MeasureUnitDto>();
            CreateMap<MeasureUnit, MeasureUnitSaveDto>().ReverseMap();
            CreateMap<MeasureUnit, MeasureUnitSimpleDto>().ReverseMap();

        }

    }
}
