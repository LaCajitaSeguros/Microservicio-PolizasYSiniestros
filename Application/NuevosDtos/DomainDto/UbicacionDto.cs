using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NuevosDtos.DomainDto
{
    public class UbicacionDto
    {
        public string Provincia { get; set; }
       
        public string Localidad { get; set; }

        public string Calle { get; set; }

        public int Altura { get; set; }
    }
}
