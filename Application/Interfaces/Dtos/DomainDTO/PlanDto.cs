using Application.Dtos.Requets.DtosUtils;

namespace Application.Dtos.DomainDTO
{
    public class PlanDTO
    {
        public string Nombre { get; set; }
        public List<PlanCoberturaRequestDto> Coberturas { get; set; }
    }
}
