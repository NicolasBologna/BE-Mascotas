using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_CRUDMascotas.Models.Entities
{
    public class Duenio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long Celular { get; set; }
        public List<Mascota> Mascota { get; set; }
    }
}
