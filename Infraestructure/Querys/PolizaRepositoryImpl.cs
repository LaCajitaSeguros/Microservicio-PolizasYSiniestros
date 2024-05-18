using Application.Interfaces.Repository;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Querys
{
    public class PolizaRepositoryImpl : IPolizaRepository
    {
        private readonly ApplicationDbContext _context;

        public PolizaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Poliza> BuscarPolizaPorNroPoliza(int nroPoliza)
        {
            Poliza polizaEncontrada = await _context.Poliza.FirstOrDefaultAsync(p => p.NroDePoliza == nroPoliza);

            return polizaEncontrada;
        }
    }
}
    

