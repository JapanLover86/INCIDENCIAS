using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Recursos
    {

        [Key]
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 99999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdRecursos { get; set; }

        [Required(ErrorMessage = "El nombre debe de ser necesario")]
        public string nombreRec {  get; set; }

        public double cantidad { get; set; }

        public string desRec { get; set; }

        public IEnumerable<AsignacionRecursos> AsignacionRecursos { get; set; }

    }
}
