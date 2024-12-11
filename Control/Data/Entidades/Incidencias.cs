using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Incidencias
    {
        [Key]
        public int IdIncidencias { get; set; }

        [Required]
        [MaxLength(500)]
        public string DescInc { get; set; }

        [Required]
        public DateTime FechaReporte { get; set; }

        public DateTime FechaSolucion { get; set; }

        [Required]
        public int? IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public int? IdLaboratorio { get; set; }
        public Laboratorios Laboratorio { get; set; }

        [Required]
        public int? IdEquipos { get; set; }
        public Equipos Equipos { get; set; }

        public ICollection<AsignacionRecursos> AsignacionRecursos { get; set; }
        public ICollection<HistorialIncidencias> HistorialIncidencias { get; set; }

    }
}
