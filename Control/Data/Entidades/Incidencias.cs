using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Incidencias
    {
        [Key]
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 99999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdIncidencias {  get; set; }

        [Required(ErrorMessage = "la descripcion es necesaria")]
        public string descInc { get; set; }

        [Required(ErrorMessage = "La fecha es necesaria")]
        public DateOnly FechaReportado { get; set; }

        [Required(ErrorMessage = "La fecha es necesaria")]
        public DateOnly FechaResolucion { get; set; }




        // Clave foránea hacia Equipos
        [Required(ErrorMessage = "El equipo es necesario")]
        public int IdEquipos { get; set; }
        public int IdUsuario { get; set; }
        public int IdLaboratorio { get; set; }


        // Relación con la clase Equipos 
        public Equipos Equipos { get; set; }

        // Relación con la clase usuario
        public Usuario Usuario { get; set; }
        
        // Relación con la clase laboratorios
        public Laboratorios Laboratorios { get; set; }
        



        //relación 
        public IEnumerable<AsignacionRecursos> AsignacionRecursos { get; set; }
        public IEnumerable<HistorialIncidencias> HistorialIncidencias { get; set; }

    }
}
