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
            await contextodb.Equipos.AddAsync(equipos);
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
                contextodb.Equipos.Remove(equipos);
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
            return await contextodb.Equipos.ToListAsync();
        }

        public async Task<IEnumerable<Equipos>> GetOne(int id)
        {
            var buscarEquipos = await contextodb.Equipos.FirstOrDefaultAsync(e => e.IdEquipos == id);
            if (buscarEquipos is null )
            {
                new Equipos();
            }
            return (IEnumerable<Equipos>)buscarEquipos;
        }

        public async  Task<Equipos> Modificar(Equipos equipos)
        {
            var modificarEquipo = await contextodb.Equipos.FirstOrDefaultAsync<Equipos>();
            if (modificarEquipo is not null)
            {
                contextodb.Equipos.Update(equipos);
                await contextodb.SaveChangesAsync();
                return modificarEquipo;
            }
            return equipos;
        }
    }
}
