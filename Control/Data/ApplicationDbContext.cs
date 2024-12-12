
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) { }

    // DbSet para cada entidad
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Incidencias> Incidencias { get; set; }
    public DbSet<AsignacionRecursos> AsignacionRecursos { get; set; }
    public DbSet<Equipos> Equipos { get; set; }
    public DbSet<HistorialIncidencias> historialIncidencias { get; set; }
    public DbSet<Laboratorios> laboratorios { get; set; }
    public DbSet<Recursos> recursos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Usuario>().HasData(
            
            new Usuario { IdUsuario = 312122, NombreUsuario  = "Jorgito", CorreoUsuario = "Jorgito@upla.edu.pe", RolUsuario = "Docente", TipoUsuario = "Principal"  }
            
            
            );

        modelBuilder.Entity<AsignacionRecursos>().HasData(
            
            new AsignacionRecursos {  IdAsignacion = 123512, CantidadUtilizada = 34522}
            
            
            );

        modelBuilder.Entity<Equipos>().HasData(
            
            new Equipos {  IdEquipos = 34112, NombreEquipos = "LAB-01", FechaInst = new DateTime(2024, 12, 14), Modelo = "Lenovo"}

            
            
            );


        modelBuilder.Entity<HistorialIncidencias>().HasData(
            
            new HistorialIncidencias { IdHistorial = 123553, Comentarios = "Esta computadora fue reparada", Accion = "Reparada", UsuarioRes = "Jorgito"}
            
            
            );


        modelBuilder.Entity<Incidencias>().HasData(
            
            new Incidencias { IdIncidencias = 1251222, DescInc = "Sucedio mientras alguien movia..", FechaReporte = new DateTime(2024, 12, 05), FechaSolucion = new DateTime (2024, 12, 15)}
            
            
            
            );

        modelBuilder.Entity<Laboratorios>().HasData(
            
            new Laboratorios {  IdLaboratorio = 34123, NombreLab = "LAB-01", Capacidad = 25, Ubicacion = "Upla-Huancayo"}
            
            
            );

        modelBuilder.Entity<Recursos>().HasData(
            
            new Recursos { IdRecursos = 235121, NombreRec = "Recurso compartido", DesRec = "Se necesito el recurso"}
            
            
            );


        
        
        


    }
}
