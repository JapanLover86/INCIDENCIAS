using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Recursos
    {

        [Key]
        public int IdRecursos { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreRec { get; set; }

        [MaxLength(500)]
        public string DesRec { get; set; }

        public ICollection<AsignacionRecursos> AsignacionRecursos { get; set; }

    }
}
