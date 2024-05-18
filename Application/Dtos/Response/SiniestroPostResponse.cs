using Application.Dtos.DomainDTO;

namespace Application.Dtos.Response
{
    public  class SiniestroPostResponse
    {
        public int NroPoliza {  get; set; }
        public SiniestroDTO Siniestro { get; set; }
    }
}
