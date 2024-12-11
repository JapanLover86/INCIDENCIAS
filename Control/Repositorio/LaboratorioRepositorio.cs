using Control.Data;
using Control;
using Control.Data.Entidades;
using Control.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class LaboratorioRepositorio : ILaboratoriosRepositorio
    {
        private readonly ApplicationDbContext contextoDb;
        

        public LaboratorioRepositorio(ApplicationDbContext dbContext)
        {
            contextoDb = dbContext;
                
        }

        public async Task<Data.Entidades.Laboratorios> Agregar(Data.Entidades.Laboratorios laboratorios)
        {
            if (laboratorios == null)
            {
                throw new ArgumentNullException(nameof(laboratorios));
            }

            try
            {
                await contextoDb.laboratorios.AddAsync(laboratorios);
                await contextoDb.SaveChangesAsync();
                return laboratorios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el laboratorio", ex);
            }
        }

        public async Task<Data.Entidades.Laboratorios> Eliminar(Data.Entidades.Laboratorios laboratorios)
        {
            if (laboratorios == null)
            {
                throw new ArgumentNullException(nameof(laboratorios), "El laboratorio no debe ser nulo");
            }

            try
            {
                contextoDb.laboratorios.Remove(laboratorios);
                await contextoDb.SaveChangesAsync();
                return laboratorios;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error al eliminar el laboratorio con ID {laboratorios.IdLaboratorio}", ex);
            }
        }

        public async Task<IEnumerable<Data.Entidades.Laboratorios>> GetAll()
        {
            try
            {
                return await contextoDb.laboratorios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los laboratorios", ex);
            }
        }

        public async Task<IEnumerable<Data.Entidades.Laboratorios>> GetOne(int id)
        {
            try
            {
                var resultado = await contextoDb.laboratorios.FirstOrDefaultAsync(l => l.IdLaboratorio == id);

                if (resultado == null)
                {
                    throw new Exception($"No se encontró el laboratorio con ID {id}");
                }

                return (IEnumerable<Data.Entidades.Laboratorios>)resultado;
            }

            catch (Exception ex)
            {
                throw new Exception($"Error al buscar el laboratorio con ID {id}", ex);
            }
        }

        public async Task<Data.Entidades.Laboratorios> Modificar(Data.Entidades.Laboratorios laboratorios)
        {
            if (laboratorios == null)
            {
                throw new ArgumentNullException(nameof(laboratorios));
            }

            try
            {
                var labExistente = await contextoDb.laboratorios.FirstOrDefaultAsync(l => l.IdLaboratorio == laboratorios.IdLaboratorio);

                if (labExistente == null)
                {
                    throw new Exception($"No se encontró el laboratorio con ID {laboratorios.IdLaboratorio}");
                }

                contextoDb.Entry(labExistente).CurrentValues.SetValues(laboratorios);
                await contextoDb.SaveChangesAsync();

                return labExistente;
            }

            catch (Exception ex)
            {
                throw new Exception(
                    $"Error al modificar el laboratorio con ID {laboratorios.IdLaboratorio}", ex);
            }
        }
    }
    
}
