using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Equipos
    {
        [Key]
        [Required(ErrorMessage ="El id es necesario para el equipo")]
        public int IdEquipos { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreEquipos { get; set; }

        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        public DateTime FechaInst { get; set; }

        

    }
}
