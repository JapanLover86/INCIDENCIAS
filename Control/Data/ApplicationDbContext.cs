
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
            
            new Laboratorios { IdLaboratorio = 23532, NombreLab = "LAB-01", Capacidad = 34, Ubicacion = "Upla-Huancayo", Incidencias = null, Equipos = null}

            
            );
    }
}
