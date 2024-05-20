using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class BienAseguradoDto
    {
        public string Patente { get; set; }
        public int CodChasis { get; set; }
        public int CodMotor { get; set; }
        public bool TieneGnc { get; set; }
        public bool UsoParticular { get; set; }
        public VehiculoVersioDto  version { get; set; }

        public UbicacionDto Ubicacion { get; set; }
    }
}
