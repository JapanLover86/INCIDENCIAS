using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IIncidenciasRepositorio
    {

        public Task< Incidencias> Agregar (Incidencias incidencias);

        public Task< Incidencias> Modificar (Incidencias incidencias); 

        public Task< Incidencias> Eliminar  (Incidencias incidencias);

        public Task< IEnumerable<Incidencias>> GetOne(int id);

        public Task< IEnumerable<Incidencias>> GetAll();


    }
}
