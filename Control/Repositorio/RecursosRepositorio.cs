
using Control.Data;
using Control.Data.Entidades;
using Control.Migrations;

namespace Control.Repositorio
{
    public class RecursosRepositorio : IRecursosRepositorio
    {
        public readonly ApplicationDbContext contextodb;

        public RecursosRepositorio(ApplicationDbContext dbContext)
        {
            contextodb = dbContext;
        }
        public async Task<Data.Entidades.Recursos> Agregar(Data.Entidades.Recursos recursos)
        {
            // Agregar el recurso a la base de datos
            object values = await contextodb.Recursos.AddAsync(recursos);
            await contextodb.SaveChangesAsync();
            return recursos;
        }

        public Task<Data.Entidades.Recursos> Eliminar(Data.Entidades.Recursos recursos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Data.Entidades.Recursos>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Data.Entidades.Recursos>> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Data.Entidades.Recursos> Modificar(Data.Entidades.Recursos recursos)
        {
            throw new NotImplementedException();
        }
    }
}
