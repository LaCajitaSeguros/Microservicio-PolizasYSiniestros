using Domain.Entitys;

namespace Application.Interfaces.Repository
{
    public interface IPolizaRepository
    {
        public Task<Poliza> BuscarPolizaPorNroPoliza(int nroPoliza);
    }
}
