using Application.Dtos.DomainDTO;

namespace Application.Dtos.Requets.DtosUtils
{
    public class SiniestroRequestDto
    {
        public DateTime Fecha { get; set; }

        public List<TipoSiniestroDTO> TiposDeSiniestros { get; set; }

        public string Observacion { get; set; }

        public UbicacionRequestDto Ubicacion { get; set; }


        public List<ImagenDTO> Imagenes { get; set; }

        public bool TieneTercerosInvolucrados { get; set; }

        //public List<TercerosInvolucradosDTO> TercerosInvolucrados { get; set; }
    }
}
