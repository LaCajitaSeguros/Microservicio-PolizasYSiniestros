
using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class SiniestroDto
    {
        public int SiniestroId { get; set; }
        public TipoSiniestroDTO TipoDeSiniestros { get; set; }
        
        public UbicacionDto Ubicacion { get; set;}

        public List<TercerosInvolucradosDto> TercerosInvolucrados { get; set; } 

    }
}
