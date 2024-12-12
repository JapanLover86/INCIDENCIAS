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
            await contextodb.Incidencias.AddAsync(incidencias);
            await contextodb.SaveChangesAsync();
            return incidencias;
        }

        public async Task<Incidencias> Eliminar(Incidencias incidencias)
        {
            if (incidencias is null) 
            {
                throw new ArgumentNullException(nameof(incidencias),"Las incidencias no deben de ser nulos");

            }
            try
            {
                contextodb.Incidencias.Remove(incidencias);
                await contextodb.SaveChangesAsync();
                return incidencias;
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error al eliminar el incidente {incidencias.IdIncidencias} ",ex);
            }

        }

        public async Task<IEnumerable<Incidencias>> GetAll()
        {
            return await contextodb.Incidencias.ToListAsync();

            
        }

        public async Task<IEnumerable<Incidencias>> GetOne(int id)
        {
            var buscarIncidente = await contextodb.Incidencias.FirstOrDefaultAsync();
            if (buscarIncidente == null)
            {
                new Incidencias();
            
            }
            return (IEnumerable<Incidencias>)buscarIncidente;
            
        }

        public async Task<Incidencias> Modificar (Incidencias incidencias)
        {
            var modifcarInciddencias = await contextodb.Incidencias.FirstOrDefaultAsync(i => i.IdIncidencias == incidencias.IdIncidencias);
            if (modifcarInciddencias is not null)
            {
                incidencias.DescInc = modifcarInciddencias.DescInc;
                await contextodb.SaveChangesAsync();
                return incidencias;
            }
            return incidencias;
        }
    }
}
