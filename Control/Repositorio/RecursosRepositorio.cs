
using Control.Data;
using Control.Data.Entidades;
using Control.Migrations;

namespace Control.Repositorio
{
    public class RecursosRepositorio : IRecursosRepositorio
    {
        public Task<Recursos> Agregar(Recursos recursos)
        {
            throw new NotImplementedException();
        }

        public Task<Recursos> Eliminar(Recursos recursos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recursos>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recursos>> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Recursos> Modificar(Recursos recursos)
        {
            throw new NotImplementedException();
        }
    }
}
