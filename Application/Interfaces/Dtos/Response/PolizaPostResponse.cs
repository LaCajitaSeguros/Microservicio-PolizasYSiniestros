using Application.Dtos.DomainDTO;
using Application.Dtos.Response.DtosUtils;

namespace Application.Dtos.Response
{
    public class PolizaPostResponse
    {
        public int NumeroDePoliza { get; set; }
        public decimal Prima { get; set; }

        public PlanDTO Plan { get; set; }

        public BienAseguradoResponseDto BienAsegurado { get; set; }
    }
}
