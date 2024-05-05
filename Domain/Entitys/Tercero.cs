using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entitys
{
    public class Tercero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TerceroId { get; set; }
        public string Nombre { get; set; }
        public int Patente { get; set; }
        public string CompaniaSeguro { get; set; }

        public int Telefono { get; set; }

        //Armo las relaciones

        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set; }


        public int SiniestroId { get; set; }
        public Siniestro Siniestro { get; set; }

    }
}
