using Application.NuevosDtos.DomainDto;
using Domain.Entitys;

namespace Application.Interfaces.Service
{
    public interface IFormateoUbicacionService
    {
        public Task<BienAseguradoDto> MapearUbicacionBienAsegurado(BienAsegurado bienAsegurado);


    }
}
