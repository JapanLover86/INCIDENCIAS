using Control.Data.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Control.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AsignacionRecursos> asignacionRecursos { get; set; }
        public DbSet<Equipos> equipos { get; set; }
        public DbSet<HistorialIncidencias> historialIncidencias { get; set; }
        public object HistorialIncidencias { get; internal set; }
        public DbSet<Incidencias> incidencias { get; set; }
        public DbSet<Laboratorios> laboratorios { get; set; }
        public DbSet<Recursos> recursos { get; set; }
        public object Recursos { get; internal set; }
        public DbSet<Usuario> usuarios { get; set; }
        public object Usuarios { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configurar relaciones con Fluent API
            builder.Entity<AsignacionRecursos>()
                .HasOne(a => a.Incidencias)
                .WithMany(i => i.AsignacionRecursos)
                .HasForeignKey(a => a.IdIncidencias)
                .OnDelete(DeleteBehavior.NoAction);  // NO CASCADE

            builder.Entity<AsignacionRecursos>()
                .HasOne(a => a.Recursos)
                .WithMany(r => r.AsignacionRecursos)
                .HasForeignKey(a => a.IdRecursos)
                .OnDelete(DeleteBehavior.NoAction);  // NO CASCADE

            builder.Entity<Incidencias>()
                .HasOne(i => i.Equipos)
                .WithMany(e => e.Incidencias)
                .HasForeignKey(i => i.IdEquipos)
                .OnDelete(DeleteBehavior.NoAction);  // NO CASCADE

            builder.Entity<Incidencias>()
                .HasOne(i => i.Laboratorios)
                .WithMany(l => l.Incidencias)
                .HasForeignKey(i => i.IdLaboratorio)
                .OnDelete(DeleteBehavior.SetNull);  // NO CASCADE

            builder.Entity<Incidencias>()
                .HasOne(i => i.Usuario)
                .WithMany(u => u.Incidencias)
                .HasForeignKey(i => i.IdUsuario)
                .OnDelete(DeleteBehavior.NoAction);  // NO CASCADE

            builder.Entity<HistorialIncidencias>()
                .HasOne(h => h.Incidencias)
                .WithMany(i => i.HistorialIncidencias)
                .HasForeignKey(h => h.IdIncidencias)
                .OnDelete(DeleteBehavior.NoAction);  // NO CASCADE
        }


    
    }


}
