
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) { }

    // DbSet para cada entidad
    public DbSet<Usuario> usuarios { get; set; }
    public DbSet<Incidencias> incidencias { get; set; }
    public DbSet<AsignacionRecursos> asignacionRecursos { get; set; }
    public DbSet<Equipos> equipos { get; set; }
    public DbSet<HistorialIncidencias> historialIncidencias { get; set; }
    public DbSet<Laboratorios> laboratorios { get; set; }
    public DbSet<Recursos> recursos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Laboratorios>().HasData(

            new Laboratorios { IdLaboratorio = 23532, NombreLab = "LAB-01", Capacidad = 34, Ubicacion = "Upla-Huancayo", Incidencias = null, Equipos = null }


            );


        modelBuilder.Entity<Equipos>().HasData(

            new Equipos { IdEquipos = 23454, IdLaboratorio = null, Incidencias = null, NombreEquipos = "PC-01", FechaInst = new DateTime(2024, 12, 11), Laboratorio = null, Modelo = "Lenovo" }


            );


        modelBuilder.Entity<Incidencias>().HasData(

            new Incidencias { IdIncidencias = 23545, IdLaboratorio = null, HistorialIncidencias = null, AsignacionRecursos = null, DescInc = "Se malogró una pc", Equipos = null, IdUsuario = null, IdEquipos = null, Laboratorio = null, Usuario = null, FechaReporte = new DateTime(2024, 12, 15), FechaSolucion = new DateTime(2024, 12, 18) }


            );

        modelBuilder.Entity<Recursos>().HasData(

            new Recursos { IdRecursos = 34532, DesRec = "Se requiere un monto especifico para este trabajo", NombreRec = "Recurso-01", AsignacionRecursos = null }


            );

        modelBuilder.Entity<AsignacionRecursos>().HasData(

            new AsignacionRecursos { IdAsignacion = 23564, CantidadUtilizada = 23444, IdRecursos = 34532, Incidencias = null, IdIncidencias = 23545, Recursos = null }

            );

        modelBuilder.Entity<HistorialIncidencias>().HasData(

            new HistorialIncidencias { IdHistorial = 57622, Comentarios = "Se malogró una pc", Incidencias = null, Accion = "Corregida", IdIncidencias = null, UsuarioResponsable = "Jorge" }

            );

        modelBuilder.Entity<Usuario>().HasData(

            new Usuario { IdUsuario = 23223, CorreoUsuario = "jorgito@upla.edu.pe", Incidencias = null, NombreUsuario = "Jorge", RolUsuario = "Ingeniero", TipoUsuario = "Desarrollador" }

            );
        
        


    }
}
