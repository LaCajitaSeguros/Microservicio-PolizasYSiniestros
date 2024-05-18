using Application.Dtos.Requets;
using Application.Dtos.Response;

namespace Application.Interfaces.Service
{
    public interface ISiniestroService
    {
        public Task<SiniestroPostRequest> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest);
    }
}
