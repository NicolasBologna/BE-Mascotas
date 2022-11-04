using BE_CRUDMascotas.Models.Entities;

namespace BE_CRUDMascotas.Models.Repository
{
    public interface IMascotaRepository
    {
        List<Mascota> GetListMascotas();
        Mascota GetMascota(int id);
        void DeleteMascota(Mascota mascota);
        Mascota AddMascota(Mascota mascota);
        void UpdateMascota(Mascota mascota);
    }
}
