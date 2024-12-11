using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Equipos
    {
        [Key]
        public int IdEquipos { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreEquipos { get; set; }

        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        public DateTime FechaInst { get; set; }

        [Required]
        public int IdLaboratorio { get; set; }
        public Laboratorios Laboratorio { get; set; }

        public ICollection<Incidencias> Incidencias { get; set; }


    }
}
