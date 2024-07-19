using Application.Dtos.Requets;
using Application.Dtos.Response;
using Application.Dtos.Response.DtosUtils;

namespace Application.Interfaces.Service
{
    public interface IPolizaService
    {
        public Task<PolizaPostResponse> GuardarPolizaAsync(PolizaPostRequest polizaPostRequest);
        //public Task<List<PolizaGetResponse>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId);

        public Task<List<PolizaResponseDto>> BuscarPolizasConSiniestrosPorUsuarioId(string usuarioId);
    }
}
