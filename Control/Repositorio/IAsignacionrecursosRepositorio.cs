using Control.Data.Entidades;
using System.Threading.Tasks;

namespace Control.Repositorio
{
    public interface IAsignacionrecursosRepositorio
    {

        public Task <AsignacionRecursos> Agregar(AsignacionRecursos asignacionRecursos);

        public Task <AsignacionRecursos> Modificar(AsignacionRecursos asignacionRecursos);

        public Task <AsignacionRecursos> Eliminar(AsignacionRecursos asignacionRecursos);

        public Task<IEnumerable<AsignacionRecursos?>> GetOne(int id);

        public Task<IEnumerable<AsignacionRecursos>> GetAll();

        public Task Actualizar(AsignacionRecursos asignacionRecursos);



    }
}
