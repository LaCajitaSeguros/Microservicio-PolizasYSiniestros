using Application.Dtos.DomainDTO;

namespace Application.Dtos.Response.DtosUtils
{
    public class SiniestroResponseDto
    {
        public int SiniestroId { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public List<TipoSiniestroResponseDto> TipoDeSiniestros { get; set; }
        public List<ImagenDTO> Imagenes { get; set; }


        public UbicacionResponseDto Ubicacion { get; set; }

        public bool TieneTercerosInvolucrados { get; set; }

        //public List<TercerosInvolucradosDto> TercerosInvolucrados { get; set; }

    }
}
