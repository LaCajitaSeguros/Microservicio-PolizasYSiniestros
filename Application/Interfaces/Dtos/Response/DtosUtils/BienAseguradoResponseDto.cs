namespace Application.Dtos.Response.DtosUtils
{
    public class BienAseguradoResponseDto
    {
        public string Patente { get; set; }
        public string CodChasis { get; set; }
        public string CodMotor { get; set; }
        public bool TieneGnc { get; set; }
        public bool UsoParticular { get; set; }
        public VehiculoVersioResponseDto version { get; set; }

        public UbicacionResponseDto Ubicacion { get; set; }
    }
}
