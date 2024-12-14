using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class AsignacionrecursosRepositorio : IAsignacionrecursosRepositorio
    {
        public readonly AplicacionDbContext contextodb;

        public AsignacionrecursosRepositorio(AplicacionDbContext dbContext)
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
                    throw new Exception($"Error al eliminar la asignación de recursos con ID  {asignacionRecursos.IdAsignacion}", ex);
            }
        }

        public async Task<IEnumerable<AsignacionRecursos>> GetAll()
        {
            return await contextodb.asignacionRecursos.ToListAsync();
        }

        public async Task<IEnumerable<AsignacionRecursos>> GetOne(int id)
        {
            var resultBusqueda = await contextodb.asignacionRecursos.FirstOrDefaultAsync(c => c.IdAsignacion == id);
            return (IEnumerable<AsignacionRecursos>)resultBusqueda; 
        }

        public async Task<AsignacionRecursos> Modificar(AsignacionRecursos asignacionRecursos)
        {
            var modificarRecurso = await contextodb.asignacionRecursos.FirstOrDefaultAsync(c => c.IdAsignacion == asignacionRecursos.IdAsignacion);
            if(modificarRecurso is not null)
            {
                asignacionRecursos.CantidadUtilizada = modificarRecurso.CantidadUtilizada;
                contextodb.asignacionRecursos.Update(asignacionRecursos);   
                return modificarRecurso;
            }
            return asignacionRecursos;  
        }


        public async Task Actualizar(AsignacionRecursos asignacion)
        {
            var asignacionExistente = await contextodb.asignacionRecursos.FindAsync(asignacion.IdAsignacion);
            if (asignacionExistente != null)
            {
                asignacionExistente.CantidadUtilizada = asignacion.CantidadUtilizada;
                contextodb.asignacionRecursos.Update(asignacionExistente); // Rastreo explícito
                await contextodb.SaveChangesAsync();
            }
            else
            {
                throw new Exception("La asignación no se encontró para actualizar.");
            }
        }




    }
}
