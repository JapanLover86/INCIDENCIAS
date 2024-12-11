
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

    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);

        //tabla laboratorio


        Builder.Entity<Laboratorios>().HasData(
            
            new Laboratorios { IdLaboratorio = 435642, Capacidad = 24, NombreLab = "Lab-01", Ubicacion ="Pabellón I" }
            
            );


    }
}
