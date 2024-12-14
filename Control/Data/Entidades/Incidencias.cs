using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Incidencias
    {
        [Key]
        [Required(ErrorMessage ="El id es obligatorio")]
        [Range(0, 99999, ErrorMessage ="El rango como máximo es de cinco dígitos")]
        public int IdIncidencias { get; set; }

        [StringLength(5, ErrorMessage = "La descripción debe tener 5 caracteres")]
        [MaxLength(500)]
        public string DescInc { get; set; }

        [Required]
        public DateTime FechaReporte { get; set; }

        public DateTime FechaSolucion { get; set; }

        

        

        

        

    }
}
