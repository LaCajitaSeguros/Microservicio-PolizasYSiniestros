using Application.Dtos.Response.DtosUtils;

namespace Application.Interfaces.Service
{
    public interface IFormateoVehiculoVersionService
    {
        public Task<VehiculoVersioResponseDto> MapearVehiculoVersion(int versionId);
    }
}
