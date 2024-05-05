using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class MarcaConfiguracion : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasData(
                new Marca { MarcaId = 1, NombreMarca = "Fiat"},
                new Marca { MarcaId = 2, NombreMarca = "Ford"},
                new Marca { MarcaId = 3, NombreMarca = "BMW" }
                );
        }
    }
}