using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class EquiposRepositorio : IEquiposRepositorio
    {
        public readonly AplicacionDbContext contextodb;
        public EquiposRepositorio(AplicacionDbContext dbContext)
        {
            contextodb = dbContext;
        }

        public async Task<Equipos> Agregar(Equipos equipos)
        {
            await contextodb.equipos.AddAsync(equipos);
            await contextodb.SaveChangesAsync();
            return equipos;
        }

        public async Task<Equipos> Eliminar(Equipos equipos)
        {
            if(equipos is null)
            {
                throw new ArgumentNullException(nameof(equipos),"Error no puede ser nulo equipos");
            }
            try
            {
                contextodb.equipos.Remove(equipos);
                await contextodb.SaveChangesAsync();
                return equipos;
            }
            catch(Exception ex) 
            {
                throw new Exception($"Error al eliminar equipos {equipos.IdEquipos}", ex);
            }
        }

        public async Task<IEnumerable<Equipos>> GetAll()
        {
            return await contextodb.equipos.ToListAsync();
        }

        public async Task<IEnumerable<Equipos>> GetOne(int id)
        {
            var buscarEquipos = await contextodb.equipos.FirstOrDefaultAsync(e => e.IdEquipos == id);
            if (buscarEquipos != null)
            {
                return new List<Equipos> { buscarEquipos };  // Devolverlo como una lista
            }
            return new List<Equipos>();
        }

        public async  Task<Equipos> Modificar(Equipos equipos)
        {
            var modificarEquipo = await contextodb.equipos.FirstOrDefaultAsync<Equipos>();
            if (modificarEquipo is not null)
            {
                contextodb.equipos.Update(equipos);
                await contextodb.SaveChangesAsync();
                return modificarEquipo;
            }
            return equipos;
        }
    }
}
