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
    public class LabelService : ILabelService
    {
        private readonly ILabelRepository _labelRepository;
        private readonly IMapper _mapper;

        public LabelService(ILabelRepository labelRepository, IMapper mapper)
        {
            _labelRepository = labelRepository;
            _mapper = mapper;
        }

        public async Task<LabelDto> CreateAsync(LabelSaveDto labelSaveDto)
        {
            Label label = _mapper.Map<Label>(labelSaveDto);
            label.RegistrationDate = DateTime.Now;
            label.State = true;

            Label labelSaved = await _labelRepository.SaveAsync(label);
            return _mapper.Map<LabelDto>(labelSaved);
        }

        public async Task<LabelDto> DisabledAsync(int id)
        {
            Label label = await _labelRepository.FindByIdAsync(id);
            label.State = false;

            Label officeSaved = await _labelRepository.SaveAsync(label);

            return _mapper.Map<LabelDto>(officeSaved);
        }

        public async Task<LabelDto> EditAsync(int id, LabelSaveDto lavelSaveDto)
        {
            Label label = await _labelRepository.FindByIdAsync(id);

            _mapper.Map<LabelSaveDto, Label>(lavelSaveDto, label);

            Label labelSaved = await _labelRepository.SaveAsync(label);

            return _mapper.Map<LabelDto>(labelSaved);
        }

        public async Task<IReadOnlyList<LabelDto>> FindAllAsync()
        {
            IReadOnlyList<Label> labels = await _labelRepository.FindAllAsync();

            return _mapper.Map<IReadOnlyList<LabelDto>>(labels);
        }

        public async Task<LabelDto> FindByIdAsync(int id)
        {
            Label label = await _labelRepository.FindByIdAsync(id);

            return _mapper.Map<LabelDto>(label);

        }
    }
}
