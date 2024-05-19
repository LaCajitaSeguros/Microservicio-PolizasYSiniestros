using Application.Interfaces.Repository;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Querys
{
    public class ProvinciaRepositoryImpl : IProviciaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProvinciaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Provincia> BuscarProviciaPorIdAsync(int provinciaId)
        {
            var provincia = await _context.Provincia.FirstOrDefaultAsync(p => p.ProvinciaId == provinciaId);

            return provincia;
        }
    }
}
