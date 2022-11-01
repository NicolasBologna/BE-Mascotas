using AutoMapper;
using BE_CRUDMascotas.Models.DTO;
using BE_CRUDMascotas.Models.Entities;

namespace BE_CRUDMascotas.Models.Profiles
{
    public class MascotaProfile: Profile
    {
        public MascotaProfile()
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
        }
    }
}
