
using Control.Data;
using Control.Data.Entidades;
using Control.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio 
{

    public class RecursosRepositorio : IRecursosRepositorio
    {
        public readonly AplicacionDbContext contextodb;

        public RecursosRepositorio(AplicacionDbContext dbContext)
        {
            contextodb = dbContext;
        }
        public async Task<Data.Entidades.Recursos> Agregar(Data.Entidades.Recursos recursos)
        {
            // Agregar el recurso a la base de datos
            await contextodb.recursos.AddAsync(recursos);
            await contextodb.SaveChangesAsync();
            return recursos;
        }

        public async Task<Data.Entidades.Recursos> Eliminar(Data.Entidades.Recursos recursos)
        {
            if (recursos == null)
            {
                throw new ArgumentNullException(nameof(recursos), "El recurso no debe ser nulo");
            }

            try
            {
                contextodb.recursos.Remove(recursos);
                await contextodb.SaveChangesAsync();
                return recursos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el recurso con ID {recursos.IdRecursos}", ex);
            }
        }

        public async Task<IEnumerable<Data.Entidades.Recursos>> GetAll()
        {
            return await contextodb.recursos.ToListAsync();
        }

        public async Task<IEnumerable<Data.Entidades.Recursos>> GetOne(int id)
        {
            var recurso = await contextodb.recursos.FirstOrDefaultAsync(r => r.IdRecursos == id);
            if (recurso == null)
            {
                throw new KeyNotFoundException($"No se encontró un recurso con el ID {id}");
            }
            return (IEnumerable<Data.Entidades.Recursos>)recurso;  // Se devuelve un único recurso;
        }

        public async Task<Data.Entidades.Recursos> Modificar(Data.Entidades.Recursos recursos)
        {
            var modificarRecurso = await contextodb.recursos.FirstOrDefaultAsync(r => r.IdRecursos == recursos.IdRecursos);

            // Si el recurso existe, se actualiza
            if (modificarRecurso != null)
            {
                modificarRecurso.NombreRec = recursos.NombreRec;
                modificarRecurso.DesRec = recursos.DesRec;
                modificarRecurso.AsignacionRecursos = recursos.AsignacionRecursos;

                // Se actualiza el recurso en la base de datos
                contextodb.recursos.Update(modificarRecurso);
                await contextodb.SaveChangesAsync();

                return modificarRecurso;
            }
            throw new KeyNotFoundException($"No se encontró un recurso con ID {recursos.IdRecursos}");
        }
    }
}
