using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class ProvinciaConfiguracion : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder) {

            builder.HasData(
                new Localidad { ProvinciaId = 31, Nombre = "Buenos Aires" },
                new Localidad { ProvinciaId = 32, Nombre = "CABA" },
                new Localidad { ProvinciaId = 33, Nombre = "Catamarca" },
                new Localidad { ProvinciaId = 34, Nombre = "Chaco" },
                new Localidad { ProvinciaId = 35, Nombre = "Chubut" },
                new Localidad { ProvinciaId = 36, Nombre = "Córdoba" },
                new Localidad { ProvinciaId = 37, Nombre = "Corrientes" },
                new Localidad { ProvinciaId = 38, Nombre = "Entre Ríos" },
                new Localidad { ProvinciaId = 39, Nombre = "Formosa" },
                new Localidad { ProvinciaId = 40, Nombre = "Jujuy" },
                new Localidad { ProvinciaId = 41, Nombre = "La Pampa" },
                new Localidad { ProvinciaId = 42, Nombre = "La Rioja" },
                new Localidad { ProvinciaId = 43, Nombre = "Mendoza" },
                new Localidad { ProvinciaId = 44, Nombre = "Misiones" },
                new Localidad { ProvinciaId = 45, Nombre = "Neuquén" },
                new Localidad { ProvinciaId = 46, Nombre = "Río Negro" },
                new Localidad { ProvinciaId = 47, Nombre = "Salta" },
                new Localidad { ProvinciaId = 48, Nombre = "San Juan" },
                new Localidad { ProvinciaId = 49, Nombre = "San Luis" },
                new Localidad { ProvinciaId = 50, Nombre = "Santa Cruz" },
                new Localidad { ProvinciaId = 51, Nombre = "Santa Fe" },
                new Localidad { ProvinciaId = 52, Nombre = "Santiago del Estero" },
                new Localidad { ProvinciaId = 53, Nombre = "Tierra del Fuego" },
                new Localidad { ProvinciaId = 54, Nombre = "Tucumán" }
            );
        }
    }
}

    
    
