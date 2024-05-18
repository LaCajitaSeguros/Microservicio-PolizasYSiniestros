
namespace Application.Dtos.DomainDTO
{
    public class SiniestroDTO
    {
        public  List<TipoSiniestroDTO> Siniestros { get; set; }

        public string Observacion { get; set; }

        public UbicacionDTO Ubicacion { get; set; }


        public List<ImagenDTO> Imagenes { get; set; }

        public List<TercerosInvolucradosDTO> TercerosInvolucrados { get; set; }
    }
}
