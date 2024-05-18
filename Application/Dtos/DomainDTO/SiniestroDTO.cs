using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.DomainDTO
{
    public class SiniestroDTO
    {
        int TipoDeSiniestroID { get; set; }

        string Descripcion { get; set; }

        UbicacionDTO Ubicacion { get; set; }


        List<ImagenDTO> Imagenes { get; set; }

        List<TercerosInvolucradosDTO> TercerosInvolucrados { get; set; }
    }
}
