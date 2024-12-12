using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Data.Entidades
{
    public class AsignacionRecursos
    {
        [Key]
        public int IdAsignacion { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int CantidadUtilizada { get; set; }


       
    }
}
    

