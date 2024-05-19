using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Util.DataSet
{
    public class TipoSiniestroConfiguracion : IEntityTypeConfiguration<TipoDeSiniestro>
    {
        public void Configure(EntityTypeBuilder<TipoDeSiniestro> builder)
        {
            builder.HasData(
                 new TipoDeSiniestro { TipoDeSiniestroId = 1, Nombre = "Robo" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 2, Nombre = "Incendio" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 3, Nombre = "Choque" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 4, Nombre = "Granizo" }
                );
        }
    }
}
