using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Querys
{
    public class VersionRepositoryImpl : IVersionRepository
    {
        private readonly ApplicationDbContext _context;

        public VersionRepositoryImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<VersionVehiculo> BuscarVersionPorVersionIdAsync(int versionId)
        {
            var version = await _context.Version
               .Include(v => v.Modelo) // Carga el modelo relacionado
                   .ThenInclude(m => m.Marca) // Carga la marca asociada al modelo
               .FirstOrDefaultAsync(v => v.VersionId == versionId);

            return version;
        }

    }
}
