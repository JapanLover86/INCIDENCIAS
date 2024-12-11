namespace Control.Data.Entidades
{
    public class HistorialIncidencias
    {

        public int IdHistorial {  get; set; }

        public DateOnly fechaHistorial { get; set; }

        public string accion { get; set; }

        public string comentarios { get; set; }

        public string usuarioResponsable { get; set; }

        //foreign keys 
        public int IdIncidencias { get; set; }

        //relacion con Incidencias

        public Incidencias Incidencias { get; set; }




        //relacion con las tablas 

        


    }
}
