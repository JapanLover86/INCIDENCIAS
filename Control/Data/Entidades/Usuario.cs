using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Usuario
    {
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 99999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es necesario")]
        public string nombreUsuario { get; set; }

        [Required(ErrorMessage = "La correo es necesario")]
        public string correoUsuario { get; set; }

        public float tipoUsuario { get; set; }

        [Required(ErrorMessage = "El rol es necesaria")]
        public float rolUsuario { get; set; }

        //relación que hay con la tabla de incidencias 

        public IEnumerable<Incidencias> Incidencias { get; set; }

    }
}
