using AutoMapper;
using Jazani.Taller.Aplication.Admins.Dtos;
using Jazani.Taller.Aplication.Admins.Dtos.PermissionLabels;
using Jazani.Taller.Domain.Admins.Models;
using Jazani.Taller.Domain.Admins.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Services.Implementations
{
    public class PermissionLabelService : IPermissionLabelService
    {
        private readonly IPermissionLabelRepository _permilabelRepository;
        private readonly IMapper _mapper;

        public PermissionLabelService(IPermissionLabelRepository permilabelRepository, IMapper mapper)
        {
            _permilabelRepository = permilabelRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<PermissionLabelDto>> FindAllAsync()
        {
            IReadOnlyList<PermissionLabel> permiss = await _permilabelRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<PermissionLabelDto>>(permiss);
        }
    }
}
