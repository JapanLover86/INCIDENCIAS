using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control.Repositorio
{
    public class HistorialRepositorio : IHistorialRepositorio
    {
        public readonly ApplicationDbContext contextodb;

        public HistorialRepositorio(ApplicationDbContext dbContext)
        {
            contextodb = dbContext;
        }

        public async Task<HistorialIncidencias> Agregar(HistorialIncidencias historialIncidencias)
        {
            await contextodb.historialIncidencias.AddAsync(historialIncidencias);
            await contextodb.SaveChangesAsync();
            return historialIncidencias;
        }

        public async Task<HistorialIncidencias> Modificar(HistorialIncidencias historialIncidencias)
        {
            var historialExistente = await contextodb.historialIncidencias.FirstOrDefaultAsync(h => h.IdHistorial == historialIncidencias.IdHistorial);
            if (historialExistente is not null)
            {
              
                contextodb.historialIncidencias.Update(historialExistente);
                await contextodb.SaveChangesAsync();
                return historialExistente;
            }
            return null;
        }

        public async Task<HistorialIncidencias> Eliminar(HistorialIncidencias historialIncidencias)
        {
            contextodb.historialIncidencias.Remove(historialIncidencias);
            await contextodb.SaveChangesAsync();
            return historialIncidencias;
        }

        public async Task<IEnumerable<HistorialIncidencias>> GetAll()
        {
            return await contextodb.historialIncidencias.ToListAsync();
        }

        public async Task<HistorialIncidencias> GetOne(int id)
        {
            return await contextodb.historialIncidencias.FirstOrDefaultAsync(h => h.IdHistorial == id);
        }

        Task<IEnumerable<HistorialIncidencias>> IHistorialRepositorio.GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
