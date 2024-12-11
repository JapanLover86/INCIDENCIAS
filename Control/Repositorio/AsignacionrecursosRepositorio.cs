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
                    throw new Exception($"Error al eliminar la asignación de recursos con ID  {asignacionRecursos.IdRecursos}", ex);
            }
        }

        public async Task<IEnumerable<AsignacionRecursos>> GetAll()
        {
            return await contextodb.asignacionRecursos.ToListAsync();
        }

        public async Task<IEnumerable<AsignacionRecursos>> GetOne(int id)
        {
            var resultBusqueda = await contextodb.asignacionRecursos.FirstOrDefaultAsync(c => c.IdAsignacion == id); //LinQ arquitectura de ado.net
            if (resultBusqueda is null)
            {
                 new AsignacionRecursos(); //No sirve para web , para intranet si
            }
            return (IEnumerable<AsignacionRecursos>)resultBusqueda;


        }

        public async Task<AsignacionRecursos> Modificar(AsignacionRecursos asignacionRecursos)
        {
            var modificarRecurso = await contextodb.asignacionRecursos.FirstOrDefaultAsync(c => c.IdRecursos == asignacionRecursos.IdRecursos);
            if(modificarRecurso is not null)
            {
                asignacionRecursos.CantidadUtilizada = modificarRecurso.CantidadUtilizada;
                contextodb.asignacionRecursos.Update(asignacionRecursos);   
                return modificarRecurso;
            }
            return asignacionRecursos;  
        }
    }
}
