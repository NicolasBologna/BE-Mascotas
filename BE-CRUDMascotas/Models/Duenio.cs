namespace BE_CRUDMascotas.Models
{
    public class Duenio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public List<Mascota> Mascota { get; set; }
    }
}
