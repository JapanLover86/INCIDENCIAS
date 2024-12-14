using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Data.Entidades
{
    public class AsignacionRecursos
    {
        [Key]
        [Required(ErrorMessage = "La cantidad utilizada es obligatoria")]
        public int IdAsignacion { get; set; }

        [Required(ErrorMessage = "La cantidad utilizada es obligatoria")]
        [Range(1.0, double.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]

        public double CantidadUtilizada { get; set; }


       
    }
}
    

