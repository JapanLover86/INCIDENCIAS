using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Laboratorios
    {

        [Key]
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 999999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdLaboratorio {  get; set; }

        [Required(ErrorMessage = "El nombre es necesario")]
        public  string nombreLab {  get; set; }

        public string ubicacion { get; set; }

        [Required(ErrorMessage = "La capacidad es necesaria")]
        public int capacidad { get; set; }

        public TimeOnly horario { get; set; }

        // relacion con las tablas 

        public IEnumerable<Incidencias> Incidencias { get; set; }

        public IEnumerable<Equipos> Equipos { get; set; }
    }
}
