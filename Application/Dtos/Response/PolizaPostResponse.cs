using Application.Dtos.Requets;

namespace Application.Dtos.Response
{
    public class PolizaPostResponse
    {
        public int NumeroDePoliza { get; set; }
        public decimal Prima { get; set; }
        public PolizaPostRequest BienAsegurado { get; set; }
    }
}
