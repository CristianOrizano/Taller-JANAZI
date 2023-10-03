using AutoMapper;
using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Services.Implementations
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionRepository permiRepository, IMapper mapper)
        {
            _permissionRepository = permiRepository;
            _mapper = mapper;
        }

        public async Task<PermissionDto> CreateAsync(PermissionSaveDto permiSaveDto)
        {
            Permission permi = _mapper.Map<Permission>(permiSaveDto);
            permi.RegistrationDate = DateTime.Now;
            permi.State = true;

            Permission permiSaved = await _permissionRepository.SaveAsync(permi);

            return _mapper.Map<PermissionDto>(permiSaved);
        }

        public async Task<PermissionDto> DisabledAsync(int id)
        {
            Permission permi = await _permissionRepository.FindByIdAsync(id);
            permi.State = false;

            Permission permiSaved = await _permissionRepository.SaveAsync(permi);

            return _mapper.Map<PermissionDto>(permiSaved);
        }

        public async Task<PermissionDto> EditAsync(int id, PermissionSaveDto permiSaveDto)
        {
            Permission permiss = await _permissionRepository.FindByIdAsync(id);

            _mapper.Map<PermissionSaveDto, Permission>(permiSaveDto, permiss);

            Permission officeSaved = await _permissionRepository.SaveAsync(permiss);

            return _mapper.Map<PermissionDto>(officeSaved);
        }

        public async Task<IReadOnlyList<PermissionDto>> FindAllAsync()
        {
            IReadOnlyList<Permission> permiss = await _permissionRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<PermissionDto>>(permiss);

        }

        public async Task<PermissionDto> FindByIdAsync(int id)
        {
            Permission? permiss = await _permissionRepository.FindByIdAsync(id);

            return _mapper.Map<PermissionDto>(permiss);
        }
    }
}
