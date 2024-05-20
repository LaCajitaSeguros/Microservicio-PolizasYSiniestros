using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NuevosDtos.DomainDto
{
    public class TercerosInvolucradosDto
    {
        public string CompaniaDeSeguro { get; set; }

        public string Nombre { get; set; }

        public string Patente { get; set; }

        public UbicacionDto Ubicacion { get; set;}
    }
}
