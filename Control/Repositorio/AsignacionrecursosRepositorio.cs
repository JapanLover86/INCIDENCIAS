using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

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
            await contextodb.SaveChangesAsync();
            return asignacionRecursos;
        }

        public async Task<AsignacionRecursos> Eliminar(AsignacionRecursos asignacionRecursos)
        {
            if(asignacionRecursos == null)
            {
                throw  new ArgumentNullException((nameof(asignacionRecursos)),"La  asignación no debe de ser nula");
            }
            try
            {
                contextodb.asignacionRecursos.Remove(asignacionRecursos);
                await contextodb.SaveChangesAsync();
                return asignacionRecursos;
            }
            catch (Exception ex) 
            {
                    //Relanzar la excepcion para que el llamador pueda manejarla 
                    throw new Exception($"Error al eliminar la asignación de recursos con ID  {asignacionRecursos.IdRecursos}", ex);
            }
        }

        public async Task<IEnumerable<AsignacionRecursos>> GetAll()
        {
            return await contextodb.asignacionRecursos.ToListAsync();
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
