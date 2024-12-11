using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Equipos
    {
        [Key]
        [Required(ErrorMessage = "El id es necesario")]
        [Range(0, 99999, ErrorMessage = "El rango debe de ser de cinco dígitos")]
        public int IdEquipos {  get; set; }    

        public string nombreEquipos { get; set; }

        public float estado {  get; set; }  

        public string modelo { get; set; }

        public DateOnly fecha_inst {  get; set; }



        //foreing keys
        public int IdLaboratorio { get; set; }


        //RELACION CON laboratorio
        public Laboratorios Laboratorios { get; set; }



        // Relación con la clase Incidencias (1 Equipo -> muchas Incidencias)
        public ICollection<Incidencias> Incidencias { get; set; }


    }
}
