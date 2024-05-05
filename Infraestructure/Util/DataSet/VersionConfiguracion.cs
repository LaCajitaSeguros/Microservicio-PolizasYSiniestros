using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class VersionConfiguracion : IEntityTypeConfiguration<VersionVehiculo>
    {
        public void Configure(EntityTypeBuilder<VersionVehiculo> builder)
        {
            builder.HasData(
                new VersionVehiculo { VersionId = 1, NombreVersion = "1.4 Fire", PrecioBase = 5200000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 2, NombreVersion = "1.4 Fire Way", PrecioBase = 6700000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 3, NombreVersion = "1.7 ELX TD L/N", PrecioBase = 3600000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 4, NombreVersion = "Cargo 1.3 Fire", PrecioBase = 3200000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 5, NombreVersion = "Fire 1.3 3P LN", PrecioBase = 4500000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 6, NombreVersion = "Fire 1.3 5P LN Pack C II", PrecioBase = 8500000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 7, NombreVersion = "WE 1.8 Adventure", PrecioBase = 6487999, ModeloId = 3 },
                new VersionVehiculo { VersionId = 8, NombreVersion = "1.4 3P ELX Active", PrecioBase = 8000000, ModeloId = 3 },
                new VersionVehiculo { VersionId = 9, NombreVersion = "WE 1.7 TD Adventure X-Treme", PrecioBase = 4500000, ModeloId = 3 },
                new VersionVehiculo { VersionId = 10, NombreVersion = "1.6 5P Energy", PrecioBase = 12900000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 11, NombreVersion = "1.4 5P Edge TDCI", PrecioBase = 5000000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 12, NombreVersion = "Max 1.4 4P Ambiente TDCI", PrecioBase = 5200000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 13, NombreVersion = "2.3 DC 4X2 L/05 XL Plus", PrecioBase = 12600000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 14, NombreVersion = "3.0 TDI DC 4x2 L/06 XL", PrecioBase = 58500000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 15, NombreVersion = "3.0 Cd Xl Plus", PrecioBase = 9800000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 16, NombreVersion = "2.0 Se Plus At6", PrecioBase = 8933000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 17, NombreVersion = "1.6 S", PrecioBase = 12000000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 18, NombreVersion = "2.0 Se Plus At", PrecioBase = 10610000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 19, NombreVersion = "2.0 320i Sedan 184cv", PrecioBase = 34900000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 20, NombreVersion = "2.0 320i Sedan Executive", PrecioBase = 19900000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 21, NombreVersion = "2.0 Sdrive 20i Sportline 192cv", PrecioBase = 45000000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 22, NombreVersion = "3.0 530ia Sportline Sedan", PrecioBase = 82900000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 23, NombreVersion = "3.0 530ia Executive 258cv", PrecioBase = 17000000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 24, NombreVersion = "3.0 530ia Sportline", PrecioBase = 47900000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 25, NombreVersion = "Serie 7 4.8 750i Premium 407cv", PrecioBase = 38000000, ModeloId = 9 },
                new VersionVehiculo { VersionId = 26, NombreVersion = "erie 7 4.8 750ia Premium Stept", PrecioBase = 38000000, ModeloId = 9 },
                new VersionVehiculo { VersionId = 27, NombreVersion = "750i ", PrecioBase = 150000000, ModeloId = 9 }
                );
        }
    }
}
