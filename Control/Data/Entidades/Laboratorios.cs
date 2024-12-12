using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Laboratorios
    {

        [Key]
        public int IdLaboratorio { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreLab { get; set; }

        [MaxLength(200)]
        public string Ubicacion { get; set; }

        [Required]
        public int Capacidad { get; set; }

        
    }
}
