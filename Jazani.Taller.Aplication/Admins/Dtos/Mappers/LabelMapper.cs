﻿
using AutoMapper;
using Jazani.Taller.Domain.Admins.Models;

namespace Jazani.Taller.Aplication.Admins.Dtos.Mappers
{
    public class LabelMapper: Profile
    {
        public LabelMapper()
        {
            CreateMap<Label, LabelDto>();
        }
    }
}
