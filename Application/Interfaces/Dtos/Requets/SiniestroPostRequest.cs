using Application.Dtos.Requets.DtosUtils;

namespace Application.Dtos.Requets
{
    public class SiniestroPostRequest
    {
        public string UsuarioId { get; set; }

        public int NroDePoliza { get; set; }


        public SiniestroRequestDto Siniestro { get; set; }
    }
}
