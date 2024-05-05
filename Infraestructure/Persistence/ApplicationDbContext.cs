using Domain.Entities;
using Domain.Entitys;
using Infraestructure.Util.DataSet;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<VersionVehiculo> Version { get; set; }
        public DbSet<Poliza> Poliza { get; set; }
        public DbSet<BienAsegurado> BienAsegurado { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Siniestro> Siniestro { get; set; }
        public DbSet<Tercero> Tercero { get; set; }
        public DbSet<TipoDeSiniestro> TipoDeSiniestro { get; set; }
        public DbSet<SiniestroTipoDeSiniestro> SiniestroTipoDeSiniestro { get; set; }

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

            //Relacion uno a uno entre Siniestro y Ubicacion. El dueño de la relacion es BienAsegurado
            modelBuilder.Entity<Ubicacion>()
                .HasOne<Siniestro>(ub => ub.Siniestro)
                .WithOne(s => s.Ubicacion)
                .HasForeignKey<Siniestro>(s => s.UbicacionId)
                .OnDelete(DeleteBehavior.Cascade);


            //Relacion uno a uno entre Tercero y Ubicacion. El dueño de la relacion es BienAsegurado
            modelBuilder.Entity<Ubicacion>()
                .HasOne<Tercero>(ub => ub.Tercero)
                .WithOne(t => t.Ubicacion)
                .HasForeignKey<Tercero>(t => t.UbicacionId)
                .OnDelete(DeleteBehavior.Cascade);


            //Relacion uno a muchos entre poliza y siniestro, la fk la tiene siniestro
            modelBuilder.Entity<Siniestro>()
                .HasOne<Poliza>(s => s.Poliza)
                .WithMany(p => p.Siniestros)
                .HasForeignKey(s => s.PolizaId)
                .OnDelete(DeleteBehavior.NoAction);


            //Relacion uno a muchos entre Tercero y siniestro, la fk la tiene tercero
            modelBuilder.Entity<Tercero>()
                .HasOne<Siniestro>(t => t.Siniestro)
                .WithMany(s => s.TercerosInvolucrados)
                .HasForeignKey(s => s.SiniestroId)
                .OnDelete(DeleteBehavior.NoAction);


            //Relacion muchos a muchos entre Siniestro y TipoDeSiniestro

            modelBuilder.Entity<SiniestroTipoDeSiniestro>()
                .HasKey(sts => new { sts.SiniestroId, sts.TipoDeSiniestroId });


            modelBuilder.Entity<SiniestroTipoDeSiniestro>()
               .HasOne<Siniestro>(sts => sts.Siniestro)
               .WithMany(s => s.SiniestroTipoDeSiniestros)
               .HasForeignKey(sts => sts.SiniestroId);

            modelBuilder.Entity<SiniestroTipoDeSiniestro>()
               .HasOne<TipoDeSiniestro>(sts => sts.TipoDeSiniestro)
               .WithMany(tds => tds.SiniestroTipoDeSiniestros)
               .HasForeignKey(sts => sts.TipoDeSiniestroId);


            modelBuilder.ApplyConfiguration(new MarcaConfiguracion());
            modelBuilder.ApplyConfiguration(new ModeloConfiguracion());
            modelBuilder.ApplyConfiguration(new VersionConfiguracion());
        }
    }
}
