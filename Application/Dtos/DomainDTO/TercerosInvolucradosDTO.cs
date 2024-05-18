using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.DomainDTO
{
    public class TercerosInvolucradosDTO
    {
        public string CompaniaDeSeguros { get; set; }

        public string Nombre { get; set; }

        public string Patente { get; set; }

        public UbicacionDTO Ubicacion { get; set; }
    }
}
