using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class AsignacionRecursos
    {
        [Key]
        public int? IdAsignacion { get; set; }

        [Required]
        public int? IdIncidencias { get; set; }
        public Incidencias? Incidencias { get; set; }

        [Required]
        public int? IdRecursos { get; set; }
        public Recursos Recursos { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int CantidadUtilizada { get; set; }

    }
    
}
