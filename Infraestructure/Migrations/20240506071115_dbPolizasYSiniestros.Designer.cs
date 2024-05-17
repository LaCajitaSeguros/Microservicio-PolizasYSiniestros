﻿// <auto-generated />
using System;
using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240506071115_dbPolizasYSiniestros")]
    partial class dbPolizasYSiniestros
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            MarcaId = 1,
                            NombreMarca = "Fiat"
                        },
                        new
                        {
                            MarcaId = 2,
                            NombreMarca = "Ford"
                        },
                        new
                        {
                            MarcaId = 3,
                            NombreMarca = "BMW"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloId"));

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreModelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelo");

                    b.HasData(
                        new
                        {
                            ModeloId = 1,
                            MarcaId = 1,
                            NombreModelo = "Siena"
                        },
                        new
                        {
                            ModeloId = 2,
                            MarcaId = 1,
                            NombreModelo = "Uno"
                        },
                        new
                        {
                            ModeloId = 3,
                            MarcaId = 1,
                            NombreModelo = "Palio"
                        },
                        new
                        {
                            ModeloId = 4,
                            MarcaId = 2,
                            NombreModelo = "Fiesta"
                        },
                        new
                        {
                            ModeloId = 5,
                            MarcaId = 2,
                            NombreModelo = "Ranger"
                        },
                        new
                        {
                            ModeloId = 6,
                            MarcaId = 2,
                            NombreModelo = "Focus"
                        },
                        new
                        {
                            ModeloId = 7,
                            MarcaId = 3,
                            NombreModelo = "320"
                        },
                        new
                        {
                            ModeloId = 8,
                            MarcaId = 3,
                            NombreModelo = "530"
                        },
                        new
                        {
                            ModeloId = 9,
                            MarcaId = 3,
                            NombreModelo = "750"
                        });
                });

            modelBuilder.Entity("Domain.Entities.VersionVehiculo", b =>
                {
                    b.Property<int>("VersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersionId"));

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("NombreVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioBase")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VersionId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Version");

                    b.HasData(
                        new
                        {
                            VersionId = 1,
                            ModeloId = 1,
                            NombreVersion = "1.4 Fire",
                            PrecioBase = 5200000m
                        },
                        new
                        {
                            VersionId = 2,
                            ModeloId = 1,
                            NombreVersion = "1.4 Fire Way",
                            PrecioBase = 6700000m
                        },
                        new
                        {
                            VersionId = 3,
                            ModeloId = 1,
                            NombreVersion = "1.7 ELX TD L/N",
                            PrecioBase = 3600000m
                        },
                        new
                        {
                            VersionId = 4,
                            ModeloId = 2,
                            NombreVersion = "Cargo 1.3 Fire",
                            PrecioBase = 3200000m
                        },
                        new
                        {
                            VersionId = 5,
                            ModeloId = 2,
                            NombreVersion = "Fire 1.3 3P LN",
                            PrecioBase = 4500000m
                        },
                        new
                        {
                            VersionId = 6,
                            ModeloId = 2,
                            NombreVersion = "Fire 1.3 5P LN Pack C II",
                            PrecioBase = 8500000m
                        },
                        new
                        {
                            VersionId = 7,
                            ModeloId = 3,
                            NombreVersion = "WE 1.8 Adventure",
                            PrecioBase = 6487999m
                        },
                        new
                        {
                            VersionId = 8,
                            ModeloId = 3,
                            NombreVersion = "1.4 3P ELX Active",
                            PrecioBase = 8000000m
                        },
                        new
                        {
                            VersionId = 9,
                            ModeloId = 3,
                            NombreVersion = "WE 1.7 TD Adventure X-Treme",
                            PrecioBase = 4500000m
                        },
                        new
                        {
                            VersionId = 10,
                            ModeloId = 4,
                            NombreVersion = "1.6 5P Energy",
                            PrecioBase = 12900000m
                        },
                        new
                        {
                            VersionId = 11,
                            ModeloId = 4,
                            NombreVersion = "1.4 5P Edge TDCI",
                            PrecioBase = 5000000m
                        },
                        new
                        {
                            VersionId = 12,
                            ModeloId = 4,
                            NombreVersion = "Max 1.4 4P Ambiente TDCI",
                            PrecioBase = 5200000m
                        },
                        new
                        {
                            VersionId = 13,
                            ModeloId = 5,
                            NombreVersion = "2.3 DC 4X2 L/05 XL Plus",
                            PrecioBase = 12600000m
                        },
                        new
                        {
                            VersionId = 14,
                            ModeloId = 5,
                            NombreVersion = "3.0 TDI DC 4x2 L/06 XL",
                            PrecioBase = 58500000m
                        },
                        new
                        {
                            VersionId = 15,
                            ModeloId = 5,
                            NombreVersion = "3.0 Cd Xl Plus",
                            PrecioBase = 9800000m
                        },
                        new
                        {
                            VersionId = 16,
                            ModeloId = 6,
                            NombreVersion = "2.0 Se Plus At6",
                            PrecioBase = 8933000m
                        },
                        new
                        {
                            VersionId = 17,
                            ModeloId = 6,
                            NombreVersion = "1.6 S",
                            PrecioBase = 12000000m
                        },
                        new
                        {
                            VersionId = 18,
                            ModeloId = 6,
                            NombreVersion = "2.0 Se Plus At",
                            PrecioBase = 10610000m
                        },
                        new
                        {
                            VersionId = 19,
                            ModeloId = 7,
                            NombreVersion = "2.0 320i Sedan 184cv",
                            PrecioBase = 34900000m
                        },
                        new
                        {
                            VersionId = 20,
                            ModeloId = 7,
                            NombreVersion = "2.0 320i Sedan Executive",
                            PrecioBase = 19900000m
                        },
                        new
                        {
                            VersionId = 21,
                            ModeloId = 7,
                            NombreVersion = "2.0 Sdrive 20i Sportline 192cv",
                            PrecioBase = 45000000m
                        },
                        new
                        {
                            VersionId = 22,
                            ModeloId = 8,
                            NombreVersion = "3.0 530ia Sportline Sedan",
                            PrecioBase = 82900000m
                        },
                        new
                        {
                            VersionId = 23,
                            ModeloId = 8,
                            NombreVersion = "3.0 530ia Executive 258cv",
                            PrecioBase = 17000000m
                        },
                        new
                        {
                            VersionId = 24,
                            ModeloId = 8,
                            NombreVersion = "3.0 530ia Sportline",
                            PrecioBase = 47900000m
                        },
                        new
                        {
                            VersionId = 25,
                            ModeloId = 9,
                            NombreVersion = "Serie 7 4.8 750i Premium 407cv",
                            PrecioBase = 38000000m
                        },
                        new
                        {
                            VersionId = 26,
                            ModeloId = 9,
                            NombreVersion = "erie 7 4.8 750ia Premium Stept",
                            PrecioBase = 38000000m
                        },
                        new
                        {
                            VersionId = 27,
                            ModeloId = 9,
                            NombreVersion = "750i ",
                            PrecioBase = 150000000m
                        });
                });

            modelBuilder.Entity("Domain.Entitys.BienAsegurado", b =>
                {
                    b.Property<int>("BienAseguradoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BienAseguradoId"));

                    b.Property<string>("CodChasis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodMotor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("TieneGnc")
                        .HasColumnType("bit");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.Property<bool>("UsoParticular")
                        .HasColumnType("bit");

                    b.Property<int>("VersionId")
                        .HasColumnType("int");

                    b.HasKey("BienAseguradoId");

                    b.HasIndex("UbicacionId")
                        .IsUnique();

                    b.ToTable("BienAsegurado");
                });

            modelBuilder.Entity("Domain.Entitys.Poliza", b =>
                {
                    b.Property<int>("PolicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicaId"));

                    b.Property<int>("BienAseguradoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("NroDePoliza")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<decimal>("Prima")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PolicaId");

                    b.HasIndex("BienAseguradoId")
                        .IsUnique();

                    b.ToTable("Poliza");
                });

            modelBuilder.Entity("Domain.Entitys.Siniestro", b =>
                {
                    b.Property<int>("SiniestroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiniestroId"));

                    b.Property<string>("Imagenes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolizaId")
                        .HasColumnType("int");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("SiniestroId");

                    b.HasIndex("PolizaId");

                    b.HasIndex("UbicacionId")
                        .IsUnique();

                    b.ToTable("Siniestro");
                });

            modelBuilder.Entity("Domain.Entitys.SiniestroTipoDeSiniestro", b =>
                {
                    b.Property<int>("SiniestroId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeSiniestroId")
                        .HasColumnType("int");

                    b.HasKey("SiniestroId", "TipoDeSiniestroId");

                    b.HasIndex("TipoDeSiniestroId");

                    b.ToTable("SiniestroTipoDeSiniestro");
                });

            modelBuilder.Entity("Domain.Entitys.Tercero", b =>
                {
                    b.Property<int>("TerceroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerceroId"));

                    b.Property<string>("CompaniaSeguro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Patente")
                        .HasColumnType("int");

                    b.Property<int>("SiniestroId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("TerceroId");

                    b.HasIndex("SiniestroId");

                    b.HasIndex("UbicacionId")
                        .IsUnique();

                    b.ToTable("Tercero");
                });

            modelBuilder.Entity("Domain.Entitys.TipoDeSiniestro", b =>
                {
                    b.Property<int>("TipoDeSiniestroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoDeSiniestroId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoDeSiniestroId");

                    b.ToTable("TipoDeSiniestro");
                });

            modelBuilder.Entity("Domain.Entitys.Ubicacion", b =>
                {
                    b.Property<int>("UbicacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UbicacionId"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("UbicacionId");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.HasOne("Domain.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Domain.Entities.VersionVehiculo", b =>
                {
                    b.HasOne("Domain.Entities.Modelo", "Modelo")
                        .WithMany("vehiculoVersiones")
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Domain.Entitys.BienAsegurado", b =>
                {
                    b.HasOne("Domain.Entitys.Ubicacion", "Ubicacion")
                        .WithOne("BienAsegurado")
                        .HasForeignKey("Domain.Entitys.BienAsegurado", "UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entitys.Poliza", b =>
                {
                    b.HasOne("Domain.Entitys.BienAsegurado", "BienAsegurado")
                        .WithOne("Poliza")
                        .HasForeignKey("Domain.Entitys.Poliza", "BienAseguradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BienAsegurado");
                });

            modelBuilder.Entity("Domain.Entitys.Siniestro", b =>
                {
                    b.HasOne("Domain.Entitys.Poliza", "Poliza")
                        .WithMany("Siniestros")
                        .HasForeignKey("PolizaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entitys.Ubicacion", "Ubicacion")
                        .WithOne("Siniestro")
                        .HasForeignKey("Domain.Entitys.Siniestro", "UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poliza");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entitys.SiniestroTipoDeSiniestro", b =>
                {
                    b.HasOne("Domain.Entitys.Siniestro", "Siniestro")
                        .WithMany("SiniestroTipoDeSiniestros")
                        .HasForeignKey("SiniestroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entitys.TipoDeSiniestro", "TipoDeSiniestro")
                        .WithMany("SiniestroTipoDeSiniestros")
                        .HasForeignKey("TipoDeSiniestroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siniestro");

                    b.Navigation("TipoDeSiniestro");
                });

            modelBuilder.Entity("Domain.Entitys.Tercero", b =>
                {
                    b.HasOne("Domain.Entitys.Siniestro", "Siniestro")
                        .WithMany("TercerosInvolucrados")
                        .HasForeignKey("SiniestroId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entitys.Ubicacion", "Ubicacion")
                        .WithOne("Tercero")
                        .HasForeignKey("Domain.Entitys.Tercero", "UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siniestro");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("Domain.Entities.Modelo", b =>
                {
                    b.Navigation("vehiculoVersiones");
                });

            modelBuilder.Entity("Domain.Entitys.BienAsegurado", b =>
                {
                    b.Navigation("Poliza")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entitys.Poliza", b =>
                {
                    b.Navigation("Siniestros");
                });

            modelBuilder.Entity("Domain.Entitys.Siniestro", b =>
                {
                    b.Navigation("SiniestroTipoDeSiniestros");

                    b.Navigation("TercerosInvolucrados");
                });

            modelBuilder.Entity("Domain.Entitys.TipoDeSiniestro", b =>
                {
                    b.Navigation("SiniestroTipoDeSiniestros");
                });

            modelBuilder.Entity("Domain.Entitys.Ubicacion", b =>
                {
                    b.Navigation("BienAsegurado")
                        .IsRequired();

                    b.Navigation("Siniestro")
                        .IsRequired();

                    b.Navigation("Tercero")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}