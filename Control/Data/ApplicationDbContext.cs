// DbContext configurado para SQL Server
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuraciones adicionales si son necesarias

        // Relaci�n Usuario - Incidencias (1:N)
        modelBuilder.Entity<Incidencias>()
            .HasOne(i => i.Usuario)
            .WithMany(u => u.Incidencias)
            .HasForeignKey(i => i.IdUsuario);

        // Relaci�n Laboratorio - Equipos (1:N)
        modelBuilder.Entity<Equipos>()
            .HasOne(e => e.Laboratorio)
            .WithMany(l => l.Equipos)
            .HasForeignKey(e => e.IdLaboratorio);

        // Relaci�n Incidencias - Equipos (1:N)
        modelBuilder.Entity<Incidencias>()
            .HasOne(i => i.Equipos)
            .WithMany(e => e.Incidencias)
            .HasForeignKey(i => i.IdEquipos);

        // Relaci�n Incidencias - Laboratorios (1:N)
        modelBuilder.Entity<Incidencias>()
            .HasOne(i => i.Laboratorio)
            .WithMany(l => l.Incidencias)
            .HasForeignKey(i => i.IdLaboratorio);

        // Relaci�n AsignacionRecursos - Recursos (1:N)
        modelBuilder.Entity<AsignacionRecursos>()
            .HasOne(a => a.Recursos)
            .WithMany(r => r.AsignacionRecursos)
            .HasForeignKey(a => a.IdRecursos);

        // Relaci�n AsignacionRecursos - Incidencias (1:N)
        modelBuilder.Entity<AsignacionRecursos>()
            .HasOne(a => a.Incidencias)
            .WithMany(i => i.AsignacionRecursos)
            .HasForeignKey(a => a.IdIncidencias);

        // Relaci�n HistorialIncidencias - Incidencias (1:N)
        modelBuilder.Entity<HistorialIncidencias>()
            .HasOne(h => h.Incidencias)
            .WithMany(i => i.HistorialIncidencias)
            .HasForeignKey(h => h.IdIncidencias);

        // Configuraci�n de campos con restricciones adicionales
        modelBuilder.Entity<Usuario>().Property(u => u.CorreoUsuario).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Laboratorios>().Property(l => l.NombreLab).HasMaxLength(100).IsRequired();
    }
}
