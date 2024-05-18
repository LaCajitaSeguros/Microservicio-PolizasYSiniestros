using Application.Dtos.Requets;

namespace Application.Interfaces.Service
{
    public interface ISiniestroService
    {
        public Task<SiniestroPostRequest> RegistrarSiniestroAsync(SiniestroPostRequest siniestroPostRequest);
    }
}
