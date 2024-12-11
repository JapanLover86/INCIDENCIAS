using Control.Data;
using Control;
using Control.Data.Entidades;
using Control.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class LaboratorioRepositorio : ILaboratoriosRepositorio
    {
        private readonly ApplicationDbContext _contextoDb;
        private Laboratorios laboratorio;

        public LaboratorioRepositorio(ApplicationDbContext dbContext)
        {
            _contextoDb = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        async Task<Laboratorios> ILaboratoriosRepositorio.Agregar(Laboratorios laboratorios)
        {
            if (laboratorio == null)
            {
                throw new ArgumentNullException(nameof(laboratorio));
            }

            try
            {
                await _contextoDb.laboratorios.AddAsync(laboratorio);
                await _contextoDb.SaveChangesAsync();
                return laboratorio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el laboratorio", ex);
            }
        }

        async Task<Laboratorios> ILaboratoriosRepositorio.Eliminar(Laboratorios laboratorios)
        {
            if (laboratorio == null)
            {
                throw new ArgumentNullException(nameof(laboratorio), "El laboratorio no debe ser nulo");
            }

            try
            {
                _contextoDb.laboratorios.Remove(laboratorio);
                await _contextoDb.SaveChangesAsync();
                return laboratorio;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error al eliminar el laboratorio con ID {laboratorio.IdLaboratorio}", ex);
            }
        }

        async Task<IEnumerable<Laboratorios>> ILaboratoriosRepositorio.GetAll()
        {
            try
            {
                return await _contextoDb.laboratorios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los laboratorios", ex);
            }
        }

        async Task<IEnumerable<Laboratorios>> ILaboratoriosRepositorio.GetOne(int id)
        {
            try
            {
                var resultado = await _contextoDb.laboratorios
                    .FirstOrDefaultAsync(l => l.IdLaboratorio == id);

                if (resultado == null)
                {
                    throw new Exception($"No se encontró el laboratorio con ID {id}");
                }

                return (IEnumerable<Laboratorios>)resultado;
            }
            
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar el laboratorio con ID {id}", ex);
            }
        }

        async Task<Laboratorios> ILaboratoriosRepositorio.Modificar(Laboratorios laboratorios)
        {
            if (laboratorio == null)
            {
                throw new ArgumentNullException(nameof(laboratorio));
            }

            try
            {
                var labExistente = await _contextoDb.laboratorios
                    .FirstOrDefaultAsync(l => l.IdLaboratorio == laboratorio.IdLaboratorio);

                if (labExistente == null)
                {
                    throw new Exception($"No se encontró el laboratorio con ID {laboratorio.IdLaboratorio}");
                }

                _contextoDb.Entry(labExistente).CurrentValues.SetValues(laboratorio);
                await _contextoDb.SaveChangesAsync();

                return labExistente;
            }
            
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error al modificar el laboratorio con ID {laboratorio.IdLaboratorio}", ex);
            }
        }
    }
    }
}
