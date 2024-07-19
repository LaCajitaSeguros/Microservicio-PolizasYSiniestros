using Application.Dtos.DomainDTO;

namespace Application.Dtos.Response.DtosUtils
{
    public class PolizaResponseDto
    {
        public int NumeroDePoliza { get; set; }

        public PlanDTO Plan { get; set; }

        public decimal Prima { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaInicio { get; set; }

        public BienAseguradoResponseDto BienAsegurado { get; set; }

        public List<SiniestroResponseDto> Siniestros { get; set; }

    }
}
