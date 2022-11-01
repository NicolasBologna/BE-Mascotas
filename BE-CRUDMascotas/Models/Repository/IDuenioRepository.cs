namespace BE_CRUDMascotas.Models.Repository
{
    public interface IDuenioRepository
    {
        Task<List<Duenio>> GetListDuenios();
        Task<Duenio> GetDuenio(int id);
        Task DeleteDuenio(Duenio mascota);
        Task<Duenio> AddDuenio(Duenio mascota);
        Task UpdateDuenio(Duenio mascota);
    }
}
