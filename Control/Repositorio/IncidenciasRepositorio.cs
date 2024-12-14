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
            await contextodb.incidencias.AddAsync(incidencias);
            await contextodb.SaveChangesAsync();
            return incidencias;
        }

        public async Task<Incidencias> Eliminar(Incidencias incidencias)
        {
            if (incidencias == null)
            {
                throw new ArgumentNullException(nameof(incidencias), "Las incidencias no deben ser nulos");
            }
            try
            {
                contextodb.incidencias.Remove(incidencias);
                await contextodb.SaveChangesAsync();
                return incidencias;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el incidente {incidencias.IdIncidencias}", ex);
            }
        }

        public async Task<IEnumerable<Incidencias>> GetAll()
        {
            return await contextodb.incidencias.ToListAsync();

            
        }

        public async Task<IEnumerable<Incidencias>> GetOne(int id)
        {
            var buscarIncidente = await contextodb.incidencias.FirstOrDefaultAsync();
            if (buscarIncidente == null)
            {
                new Incidencias();

            }
            return (IEnumerable<Incidencias>)buscarIncidente;

        }

        public async Task<Incidencias> Modificar (Incidencias incidencias)
        {
            var modifcarIncidencias = await contextodb.incidencias.FirstOrDefaultAsync(i => i.IdIncidencias == incidencias.IdIncidencias);
            if (modifcarIncidencias != null)
            {
                modifcarIncidencias.DescInc = incidencias.DescInc;
                modifcarIncidencias.FechaReporte = incidencias.FechaReporte;
                modifcarIncidencias.FechaSolucion = incidencias.FechaSolucion;
                await contextodb.SaveChangesAsync();
                return modifcarIncidencias;
            }
            return null;
        }
    }
}
