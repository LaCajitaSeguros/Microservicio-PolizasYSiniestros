using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys
{
    public class Localidad
    {
        [Key]
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; }
    }
}
