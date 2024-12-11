using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class HistorialIncidencias
    {
        [Key]
        public int IdHistorial { get; set; }

        public DateOnly FechaHistorial { get; set; }

        public string Accion { get; set; }

        public string Comentarios { get; set; }

        public string UsuarioResponsable { get; set; }

        // Foreign keys
        public int IdIncidencias { get; set; }

        // Relación con Incidencias
        public Incidencias Incidencias { get; set; }
    }
}
