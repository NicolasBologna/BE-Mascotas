using BE_CRUDMascotas.Models.Entities;

namespace BE_CRUDMascotas.Models.Repository
{
    public interface IDuenioRepository
    {
        List<Duenio> GetListDuenios();
        Duenio GetDuenio(int id);
        void DeleteDuenio(Duenio duenio);
        Duenio AddDuenio(Duenio duenio);
        void UpdateDuenio(Duenio duenio);
    }
}
