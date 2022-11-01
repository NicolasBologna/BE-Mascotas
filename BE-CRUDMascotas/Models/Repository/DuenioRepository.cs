using BE_CRUDMascotas.Models.Entities;

namespace BE_CRUDMascotas.Models.Repository
{
    public class DuenioRepository : IDuenioRepository
    {
        private readonly AplicationDbContext _context;

        public DuenioRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public void Saludar()
        {

        }

        public Duenio AddDuenio(Duenio duenio)
        {
            _context.Duenios.Add(duenio);
            _context.SaveChanges();
            return duenio;
        }

        public void DeleteDuenio(Duenio duenio)
        {
            _context.Duenios.Remove(duenio);
            _context.SaveChanges();
        }

        public Duenio? GetDuenio(int id)
        {
            return _context.Duenios.SingleOrDefault(d => d.Id == id);
        }

        public List<Duenio> GetListDuenios()
        {
            return _context.Duenios.ToList();
        }

        /// <summary>
        /// Este metodo actualiza el dueño
        /// </summary>
        /// <param name="duenio"></param>
        public void UpdateDuenio(Duenio duenio)
        {
            _context.Duenios.Update(duenio);
            _context.SaveChanges();
        }
    }
}
