namespace Application.Dtos.Requets.DtosUtils
{
    public class TercerosInvolucradosRequestDto
    {
        public string CompaniaDeSeguro { get; set; }

        public string Nombre { get; set; }

        public string Patente { get; set; }

        public UbicacionRequestDto Ubicacion { get; set; }
    }
}
