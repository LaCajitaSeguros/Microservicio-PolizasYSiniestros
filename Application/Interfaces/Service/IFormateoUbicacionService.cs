using Application.Dtos.Response.DtosUtils;
using Domain.Entitys;

namespace Application.Interfaces.Service
{
    public interface IFormateoUbicacionService
    {
        public Task<BienAseguradoResponseDto> MapearUbicacionBienAsegurado(BienAsegurado bienAsegurado);
        public Task<List<SiniestroResponseDto>> MapearUbicacionSiniestros(List<Siniestro> siniestros);

    }
}
