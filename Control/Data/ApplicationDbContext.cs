
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



        modelBuilder.Entity<Usuario>().HasData(
            
            new Usuario { IdUsuario = 312122, NombreUsuario  = "Jorgito", CorreoUsuario = "Jorgito@upla.edu.pe", RolUsuario = "Docente", TipoUsuario = "Principal"  }
            
            
            );

        modelBuilder.Entity<AsignacionRecursos>().HasData(
            
            new AsignacionRecursos {  IdAsignacion = 123512, CantidadUtilizada = 350.45}
            
            
            );

        modelBuilder.Entity<Equipos>().HasData(
            
            new Equipos {  IdEquipos = 34112, NombreEquipos = "LAB-01", FechaInst = new DateTime(2024, 12, 14), Modelo = "Lenovo"}

            
            
            );


        modelBuilder.Entity<HistorialIncidencias>().HasData(
            
            new HistorialIncidencias { IdHistorial = 123553, Comentarios = "Esta computadora fue reparada", Accion = "Reparada", UsuarioRes = "Jorgito"}
            
            
            );


        

        modelBuilder.Entity<Incidencias>().HasData(
                    
            new Incidencias { IdIncidencias = 78434, DescInc = "Este reporte fue dado por un error en el sistema", FechaReporte = new DateTime(2024, 12, 12), FechaSolucion = new DateTime(2024, 12, 27), Razones = RazonIncidencia.Mantenimiento, Roles= Rol.JorgeVega }


           );

        modelBuilder.Entity<Laboratorios>().HasData(
            
            new Laboratorios {  IdLaboratorio = 34123, NombreLab = "LAB-01", Capacidad = 25, Ubicacion = "Upla-Huancayo"}
            
            
            );

        modelBuilder.Entity<Recursos>().HasData(
            
            new Recursos { IdRecursos = 235121, NombreRec = "Recurso compartido", DesRec = "Se necesito el recurso"}
            
            
            );


        
        
        


    }
}
