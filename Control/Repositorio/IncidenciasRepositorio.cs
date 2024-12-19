using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class IncidenciasRepositorio : IIncidenciasRepositorio
    {
        public readonly AplicacionDbContext contextodb;
        public IncidenciasRepositorio(AplicacionDbContext dbContext)
        {
            contextodb = dbContext;
        }

        public async Task<Incidencias> Agregar(Incidencias incidencias)
        {
            if (incidencias == null)
                throw new ArgumentNullException(nameof(incidencias));

            await contextodb.incidencias.AddAsync(incidencias);
            await contextodb.SaveChangesAsync();
            return incidencias;
        }

        public async Task<Incidencias> Eliminar(Incidencias incidencias)
        {
            if (incidencias == null)
                throw new ArgumentNullException(nameof(incidencias));

            contextodb.incidencias.Remove(incidencias);
            await contextodb.SaveChangesAsync();
            return incidencias;
        }

        public async Task<IEnumerable<Incidencias>> GetAll()
        {
            try
            {
                return await contextodb.incidencias.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetAll: {ex.Message}");
                throw;
            }
                
        }

        public async Task<Incidencias> GetOne(int id)
        {
            return await contextodb.incidencias.FindAsync(id);

        }

        public async Task<Incidencias> Modificar(Incidencias incidencias)
        {
            var incidenciaExistente = await contextodb.incidencias.FirstOrDefaultAsync(i => i.IdIncidencias == incidencias.IdIncidencias);
            if (incidenciaExistente is not null)
            {
                incidenciaExistente.DescInc = incidencias.DescInc;
                incidenciaExistente.FechaReporte = incidencias.FechaReporte;
                incidenciaExistente.FechaSolucion = incidencias.FechaSolucion;
                incidenciaExistente.Roles = incidencias.Roles;
                incidenciaExistente.Razones = incidencias.Razones;

                await contextodb.SaveChangesAsync();
                return incidenciaExistente;
            }
            return incidencias;
        }
    }
}