using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control.Repositorio
{
    public class HistorialRepositorio : IHistorialRepositorio
    {
        private readonly ApplicationDbContext _context;

        public HistorialRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<HistorialIncidencias> Agregar(HistorialIncidencias historialIncidencias)
        {
            await _context.HistorialIncidencias.AddAsync(historialIncidencias);
            await _context.SaveChangesAsync();
            return historialIncidencias;
        }

        public async Task<HistorialIncidencias> Modificar(HistorialIncidencias historialIncidencias)
        {
            var historialExistente = await _context.HistorialIncidencias.FirstOrDefaultAsync(h => h.IdHistorial == historialIncidencias.IdHistorial);
            if (historialExistente != null)
            {
                historialExistente.FechaHistorial = historialIncidencias.FechaHistorial;
                historialExistente.Accion = historialIncidencias.Accion;
                historialExistente.Comentarios = historialIncidencias.Comentarios;
                historialExistente.UsuarioResponsable = historialIncidencias.UsuarioResponsable;
                historialExistente.IdIncidencias = historialIncidencias.IdIncidencias;

                _context.HistorialIncidencias.Update(historialExistente);
                await _context.SaveChangesAsync();
                return historialExistente;
            }
            return null;
        }

        public async Task<HistorialIncidencias> Eliminar(HistorialIncidencias historialIncidencias)
        {
            _context.HistorialIncidencias.Remove(historialIncidencias);
            await _context.SaveChangesAsync();
            return historialIncidencias;
        }

        public async Task<IEnumerable<HistorialIncidencias>> GetAll()
        {
            return await _context.HistorialIncidencias.ToListAsync();
        }

        public async Task<HistorialIncidencias> GetOne(int id)
        {
            return await _context.HistorialIncidencias
                .FirstOrDefaultAsync(h => h.IdHistorial == id);
        }
    }
}
