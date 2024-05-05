using Domain.Entities;
using Domain.Entitys;
using Infraestructure.Util.DataSet;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<VersionVehiculo> Version { get; set; }
        public DbSet<Poliza> Poliza { get; set; }   
        public DbSet<BienAsegurado> BienAsegurado { get; set; }
        public DbSet<Ubicacion> Ubicacion {  get; set; }
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<VersionVehiculo>()
                .HasOne<Modelo>(vv => vv.Modelo)
                .WithMany(mod => mod.vehiculoVersiones)
                .HasForeignKey(vv => vv.ModeloId)
                .OnDelete(DeleteBehavior.Restrict);
            //Se agrego la relacion entre la Version del vehiculo y el bien asegurado, la fk la tiene el bien asegurado
            modelBuilder.Entity<VersionVehiculo>()
                .HasOne<BienAsegurado>(vv => vv.BienAsegurado)
                .WithOne(ba => ba.Version)
                .HasForeignKey<BienAsegurado>(ba => ba.VersionId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Modelo>()
                .HasOne<Marca>(mod => mod.Marca)
                .WithMany(marc => marc.Modelos)
                .HasForeignKey(mod => mod.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);


            //Relacion uno a uno entre Poliza y BienAsegurado. El sueño de la relacion es Poliza
            modelBuilder.Entity<BienAsegurado>()
                .HasOne<Poliza>(ba => ba.Poliza)
                .WithOne(p => p.BienAsegurado)
                .HasForeignKey<Poliza>(p => p.BienAseguradoId)
                .OnDelete(DeleteBehavior.Cascade);


            //Relacion uno a uno entre BienAsegurado y Ubicacion. El dueño de la relacion es BienAsegurado
            modelBuilder.Entity<Ubicacion>()
                .HasOne<BienAsegurado>(ub => ub.BienAsegurado)
                .WithOne(ba => ba.Ubicacion)
                .HasForeignKey<BienAsegurado>(ba => ba.UbicacionId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.ApplyConfiguration(new MarcaConfiguracion());
            modelBuilder.ApplyConfiguration(new ModeloConfiguracion());
            modelBuilder.ApplyConfiguration(new VersionConfiguracion());
        }
    }
}
