using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class HistorialIncidencias
    {
        [Key]
        public int IdHistorial { get; set; }

        [Required]
        public int IdIncidencias { get; set; }
        public Incidencias Incidencias { get; set; }

        [Required]
        [MaxLength(200)]
        public string Accion { get; set; }

        [MaxLength(500)]
        public string Comentarios { get; set; }

        [Required]
        [MaxLength(100)]
        public string UsuarioResponsable { get; set; }
    }
}
