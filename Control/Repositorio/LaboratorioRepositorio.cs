using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Control.Repositorio
{
    public class LaboratorioRepositorio : ILaboratoriosRepositorio
    {
        private readonly AplicacionDbContext contextoDb;

        public LaboratorioRepositorio(AplicacionDbContext dbContext)
        {
            contextoDb = dbContext;
        }

        public async Task<Laboratorios> Agregar(Laboratorios laboratorios)
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

        public async Task<Laboratorios> Eliminar(Laboratorios laboratorios)
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
                throw new Exception($"Error al eliminar el laboratorio con ID {laboratorios.IdLaboratorio}", ex);
            }
        }

        public async Task<IEnumerable<Laboratorios>> GetAll()
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

        public async Task<Laboratorios> GetOne(int id) // Cambiado de IEnumerable<Laboratorios> a Laboratorios
        {
            try
            {
                var resultado = await contextoDb.laboratorios.FirstOrDefaultAsync(l => l.IdLaboratorio == id);

                if (resultado == null)
                {
                    throw new Exception($"No se encontró el laboratorio con ID {id}");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar el laboratorio con ID {id}", ex);
            }
        }

        public async Task<Laboratorios> Modificar(Laboratorios laboratorios)
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
                throw new Exception($"Error al modificar el laboratorio con ID {laboratorios.IdLaboratorio}", ex);
            }
        }
    }
}
