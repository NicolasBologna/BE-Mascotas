﻿using AutoMapper;
using BE_CRUDMascotas.Models.DTO;

namespace BE_CRUDMascotas.Models.Profiles
{
    public class DuenioProfile : Profile
    {
        public DuenioProfile()
        {
            CreateMap<Duenio, MascotaDTO>();
            CreateMap<MascotaDTO, Duenio>();
        }
    }
}
