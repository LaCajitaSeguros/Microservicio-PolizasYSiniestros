using Application.Dtos.Requets.DtosUtils;

namespace Application.Dtos.Response
{
    public class SiniestroPostResponse
    {
        public int NumeroDeSiniestro { get; set; }

        public SiniestroRequestDto Siniestro { get; set; }
    }
}
