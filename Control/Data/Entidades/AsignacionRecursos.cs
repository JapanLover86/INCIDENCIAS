using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class AsignacionRecursos
    {
        [Key]
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 99999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdAsignacion {  get; set; }  

        public double cantidadUtilizada { get; set; }


        //llaves foráneas
        public int IdIncidencias { get; set; }
        public int IdRecursos { get; set; }


        // Relación con la clase Incidencias 
        public Incidencias Incidencias { get; set; }

        // Relación con la clase Recursos 
        public Recursos Recursos { get; set; }

        //

       
    }
    
}
