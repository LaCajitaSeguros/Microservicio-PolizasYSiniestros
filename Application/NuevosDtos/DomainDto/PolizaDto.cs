
using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class PolizaDto
    {
        public int NumeroDePoliza { get; set; }

        public PlanDTO Plan { get; set; }

        public decimal Prima { get; set; }

        public BienAseguradoDto BienAsegurado { get; set; }

        List<SiniestroDto>  Siniestros { get; set; }

    }
}
