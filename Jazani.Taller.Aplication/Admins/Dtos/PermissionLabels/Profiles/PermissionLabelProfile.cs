
using AutoMapper;
using Jazani.Taller.Domain.Admins.Models;

namespace Jazani.Taller.Aplication.Admins.Dtos.PermissionLabels.Profiles
{
    public class PermissionLabelProfile: Profile
    {
        public PermissionLabelProfile()
        {
            CreateMap<PermissionLabel,PermissionLabelDto>();

           
        }

    }
}
