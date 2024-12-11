using Control.Data.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Control.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AsignacionRecursos> asignacionRecursos { get; set; }
        public DbSet<Equipos> Equipos { get; set; }
        public DbSet<HistorialIncidencias> historialIncidencias { get; set; }
        public object HistorialIncidencias { get; internal set; }
        public DbSet<Incidencias> incidencias { get; set; }
        public DbSet<Laboratorios> laboratorios { get; set; }
        public DbSet<Recursos> recursos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configurar relaciones con Fluent API
            builder.Entity<AsignacionRecursos>()
                .HasOne(a => a.Incidencias)
                .WithMany(i => i.AsignacionRecursos)
                .HasForeignKey(a => a.IdIncidencias);

            builder.Entity<AsignacionRecursos>()
                .HasOne(a => a.Recursos)
                .WithMany(r => r.AsignacionRecursos)
                .HasForeignKey(a => a.IdRecursos);

            builder.Entity<Incidencias>()
                .HasOne(i => i.Equipos)
                .WithMany(e => e.Incidencias)
                .HasForeignKey(i => i.IdEquipos);

            builder.Entity<Incidencias>()
                .HasOne(i => i.Laboratorios)
                .WithMany(l => l.Incidencias)
                .HasForeignKey(i => i.IdLaboratorio);

            builder.Entity<Incidencias>()
                .HasOne(i => i.Usuario)
                .WithMany(u => u.Incidencias)
                .HasForeignKey(i => i.IdUsuario);

            builder.Entity<HistorialIncidencias>()
                .HasOne(h => h.Incidencias)
                .WithMany(i => i.HistorialIncidencias)
                .HasForeignKey(h => h.IdIncidencias);

            // Llamar a SeedData para inicializar los datos
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            // Datos iniciales para la tabla Laboratorios
            builder.Entity<Laboratorios>().HasData(
                new Laboratorios { IdLaboratorio = 1, nombreLab = "Laboratorio A", ubicacion = "Edificio 1", capacidad = 50, horario = new TimeOnly(8, 0) },
                new Laboratorios { IdLaboratorio = 2, nombreLab = "Laboratorio B", ubicacion = "Edificio 2", capacidad = 40, horario = new TimeOnly(9, 0) }
            );

            // Datos iniciales para la tabla Recursos
            builder.Entity<Recursos>().HasData(
                new Recursos { IdRecursos = 1, nombreRec = "Proyector", cantidad = 5, desRec = "Proyector multimedia" },
                new Recursos { IdRecursos = 2, nombreRec = "PC", cantidad = 20, desRec = "Computadoras de escritorio" }
            );

            // Datos iniciales para la tabla Usuarios
            builder.Entity<Usuario>().HasData(
                new Usuario { IdUsuario = 1, nombreUsuario = "Juan Perez", correoUsuario = "juan.perez@upla.edu", tipoUsuario = 1, rolUsuario = 10 },
                new Usuario { IdUsuario = 2, nombreUsuario = "Maria Lopez", correoUsuario = "maria.lopez@upla.edu", tipoUsuario = 2, rolUsuario = 20 }
            );

            // Datos iniciales para la tabla HistorialIncidencias
            builder.Entity<HistorialIncidencias>().HasData(
                new HistorialIncidencias { IdHistorial = 1, FechaHistorial = new DateOnly(2024, 12, 3), Accion = "Reparación iniciada", Comentarios = "PC abierta para diagnóstico", UsuarioResponsable = "Juan Perez", IdIncidencias = 1 },
                new HistorialIncidencias { IdHistorial = 2, FechaHistorial = new DateOnly(2024, 12, 4), Accion = "Reparación completada", Comentarios = "Proyector reparado", UsuarioResponsable = "Maria Lopez", IdIncidencias = 2 }
            );

            // Datos iniciales para la tabla Incidencias
            builder.Entity<Incidencias>().HasData(
                new Incidencias { IdIncidencias = 1, descInc = "PC no enciende", FechaReportado = new DateOnly(2024, 12, 1), FechaResolucion = new DateOnly(2024, 12, 5), IdEquipos = 1, IdUsuario = 1, IdLaboratorio = 1 },
                new Incidencias { IdIncidencias = 2, descInc = "Proyector dañado", FechaReportado = new DateOnly(2024, 12, 2), FechaResolucion = new DateOnly(2024, 12, 6), IdEquipos = 2, IdUsuario = 2, IdLaboratorio = 2 }
            );

            // Datos iniciales para la tabla Equipos
            builder.Entity<Equipos>().HasData(
                new Equipos { IdEquipos = 1, nombreEquipos = "PC Gamer", estado = 1, modelo = "HP Omen", fecha_inst = new DateOnly(2022, 1, 15), IdLaboratorio = 1 },
                new Equipos { IdEquipos = 2, nombreEquipos = "Impresora 3D", estado = 1, modelo = "Creality Ender 3", fecha_inst = new DateOnly(2023, 3, 10), IdLaboratorio = 2 }
            );

            // Datos iniciales para la tabla AsignacionRecursos
            builder.Entity<AsignacionRecursos>().HasData(
                new AsignacionRecursos { IdAsignacion = 1, IdIncidencias = 1, IdRecursos = 1, cantidadUtilizada = 1 },
                new AsignacionRecursos { IdAsignacion = 2, IdIncidencias = 2, IdRecursos = 2, cantidadUtilizada = 2 }
            );
        }
    }
}
