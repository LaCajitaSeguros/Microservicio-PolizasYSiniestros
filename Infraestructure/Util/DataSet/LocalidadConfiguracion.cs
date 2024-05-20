using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            builder.HasData(
                new Localidad { ProvinciaId = 1, Nombre = "Morón" },
                new Localidad { ProvinciaId = 2, Nombre = "San Justo" },
                new Localidad { ProvinciaId = 3, Nombre = "San Martín" },
                new Localidad { ProvinciaId = 4, Nombre = "Quilmes" },
                new Localidad { ProvinciaId = 5, Nombre = "Lanús" },
                new Localidad { ProvinciaId = 6, Nombre = "Avellaneda" },
                new Localidad { ProvinciaId = 7, Nombre = "Vicente López" },
                new Localidad { ProvinciaId = 8, Nombre = "San Isidro" },
                new Localidad { ProvinciaId = 9, Nombre = "Tigre" },
                new Localidad { ProvinciaId = 10, Nombre = "San Fernando" },
                new Localidad { ProvinciaId = 11, Nombre = "Pilar" },
                new Localidad { ProvinciaId = 12, Nombre = "Escobar" },
                new Localidad { ProvinciaId = 13, Nombre = "Moreno" },
                new Localidad { ProvinciaId = 14, Nombre = "Lomas de Zamora" },
                new Localidad { ProvinciaId = 15, Nombre = "Adrogué" },
                new Localidad { ProvinciaId = 16, Nombre = "Banfield" },
                new Localidad { ProvinciaId = 17, Nombre = "Temperley" },
                new Localidad { ProvinciaId = 18, Nombre = "Hurlingham" },
                new Localidad { ProvinciaId = 19, Nombre = "Ituzaingó" },
                new Localidad { ProvinciaId = 20, Nombre = "Castelar" },
                new Localidad { ProvinciaId = 21, Nombre = "Ramos Mejía" },
                new Localidad { ProvinciaId = 22, Nombre = "Merlo" },
                new Localidad { ProvinciaId = 23, Nombre = "Ezeiza" },
                new Localidad { ProvinciaId = 24, Nombre = "Berazategui" },
                new Localidad { ProvinciaId = 25, Nombre = "Florencio Varela" },
                new Localidad { ProvinciaId = 26, Nombre = "General Rodríguez" },
                new Localidad { ProvinciaId = 27, Nombre = "Villa Ballester" },
                new Localidad { ProvinciaId = 28, Nombre = "Bella Vista" },
                new Localidad { ProvinciaId = 29, Nombre = "Ciudadela" },
                new Localidad { ProvinciaId = 30, Nombre = "Quilmes" }
           );
        }
    }
}

