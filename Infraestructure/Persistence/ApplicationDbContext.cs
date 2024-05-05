using Domain.Entities;
using Infraestructure.Util.DataSet;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<VersionVehiculo> Version { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<VersionVehiculo>()
                .HasOne<Modelo>(vv => vv.Modelo)
                .WithMany(mod => mod.vehiculoVersiones)
                .HasForeignKey(vv => vv.ModeloId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Modelo>()
                .HasOne<Marca>(mod => mod.Marca)
                .WithMany(marc => marc.Modelos)
                .HasForeignKey(mod => mod.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new MarcaConfiguracion());
            modelBuilder.ApplyConfiguration(new ModeloConfiguracion());
            modelBuilder.ApplyConfiguration(new VersionConfiguracion());
        }
    }
}
