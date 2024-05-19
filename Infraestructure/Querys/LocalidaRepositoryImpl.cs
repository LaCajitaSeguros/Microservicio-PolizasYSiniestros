using Application.Interfaces.Repository;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Querys
{
    public class LocalidaRepositoryImpl : ILocalidadRepository
    {

        private readonly ApplicationDbContext _context;

        public LocalidaRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Localidad> BuscarLocalidadPorIdAsync(int localidadId)
        {

            var localidad = await _context.Localidad.FirstOrDefaultAsync(l => localidadId  == localidadId);

            return localidad;
        }
    }
}
