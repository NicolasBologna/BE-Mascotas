using System.ComponentModel.DataAnnotations;

namespace BE_CRUDMascotas.Models.DTO
{
    public class DuenioDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Celular { get; set; }
    }
}
