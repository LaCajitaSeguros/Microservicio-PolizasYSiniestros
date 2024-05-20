﻿
using Application.Dtos.DomainDTO;

namespace Application.NuevosDtos.DomainDto
{
    public class SiniestroDto
    {
        public int SiniestroId { get; set; }
        public List<TipoSiniestroDTO> TipoDeSiniestros { get; set; }
        public List<ImagenDTO> Imagenes { get; set; }

        public UbicacionDto Ubicacion { get; set; }

        public List<TercerosInvolucradosDto> TercerosInvolucrados { get; set; }

    }
}
