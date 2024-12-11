
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

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

    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);

        //tabla laboratorio


        Builder.Entity<Laboratorios>().HasData(
            
            new Laboratorios { IdLaboratorio = 456723, Incidencias= null, NombreLab = "Lab01" , Capacidad = 30, Ubicacion = "Huancayo-upla" , Equipos = null }
            
            
            );

        Builder.Entity<Equipos>().HasData(
            
            new Equipos {  IdEquipos = 346512, FechaInst = new DateTime(2024, 12, 11), Modelo = "Lenovo-01", NombreEquipos = "PC-01", Laboratorio = null, IdLaboratorio = 456723, Incidencias = }
            
            
            );
        

    }
}
