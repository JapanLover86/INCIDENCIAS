using Control.Data;
using Control.Data.Entidades;

namespace Control.Repositorio
{
    public class AsignacionrecursosRepositorio : IAsignacionrecursosRepositorio
    {
        public readonly ApplicationDbContext contextodb;

        public AsignacionrecursosRepositorio(ApplicationDbContext dbContext)
        {
            contextodb = dbContext;
            
        }

        public async Task<AsignacionRecursos> Agregar (AsignacionRecursos asignacionRecursos)
        {
            await contextodb.asignacionRecursos.AddAsync(asignacionRecursos);
        }

        public Task<AsignacionRecursos> Eliminar(AsignacionRecursos asignacionRecursos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AsignacionRecursos>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AsignacionRecursos>> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AsignacionRecursos> Modificar(AsignacionRecursos asignacionRecursos)
        {
            throw new NotImplementedException();
        }
    }
}
