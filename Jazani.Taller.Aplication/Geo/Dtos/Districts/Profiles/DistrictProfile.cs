using AutoMapper;
using Jazani.Taller.Aplication.Mc.Dtos.Auctionareas;
using Jazani.Taller.Domain.Geo.Models;
using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Geo.Dtos.Districts.Profiles
{
    public class DistrictProfile: Profile
    {
        public DistrictProfile()
        {
            CreateMap<District, DistrictDto>();
            
        }
    }
}
