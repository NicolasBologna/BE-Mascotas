namespace BE_CRUDMascotas.Models.Repository
{
    public class DuenioRepository : IDuenioRepository
    {
        private readonly AplicationDbContext _context;

        public DuenioRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public Task<Duenio> AddDuenio(Duenio mascota)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDuenio(Duenio mascota)
        {
            throw new NotImplementedException();
        }

        public Task<Duenio> GetDuenio(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Duenio>> GetListDuenios()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDuenio(Duenio mascota)
        {
            throw new NotImplementedException();
        }
    }
}
