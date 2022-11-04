using BE_CRUDMascotas.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BE_CRUDMascotas.Models.Repository
{
    public class MascotaRepository : IMascotaRepository
    {
        private readonly AplicationDbContext _context;

        public MascotaRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            _context.Add(mascota);
            _context.SaveChanges();
            return mascota;
        }

        public void DeleteMascota(Mascota mascota)
        {
            _context.Mascotas.Remove(mascota);
            _context.SaveChanges();
        }

        public List<Mascota> GetListMascotas()
        {
            return _context.Mascotas.ToList();
        }

        public Mascota? GetMascota(int id)
        {
            return _context.Mascotas.Find(id);
        }

        public void UpdateMascota(Mascota mascota)
        {
            var mascotaItem = _context.Mascotas.FirstOrDefault(x => x.Id == mascota.Id);

            if (mascotaItem != null)
            {
                mascotaItem.Nombre = mascota.Nombre;
                mascotaItem.Raza = mascota.Raza;
                mascotaItem.Edad = mascota.Edad;
                mascotaItem.Peso = mascota.Peso;
                mascotaItem.Color = mascota.Color;

                _context.SaveChanges();
            }

        }
    }
}
