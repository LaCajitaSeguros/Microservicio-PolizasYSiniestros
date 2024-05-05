using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entitys
{
    public class Ubicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UbicacionId { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId{ get; set; }
        public string Calle {  get; set; }
        public int Altura {  get; set; }


        public BienAsegurado BienAsegurado { get; set; }
    }
}
