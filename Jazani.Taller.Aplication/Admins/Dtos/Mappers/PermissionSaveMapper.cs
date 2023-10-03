using AutoMapper;
using Jazani.Taller.Domain.Admins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Dtos.Mappers
{
    public class PermissionSaveMapper: Profile
    {
        public PermissionSaveMapper() {
            CreateMap<Permission, PermissionSaveDto>().ReverseMap();
        }
        
    }
}
