using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IRecursosRepositorio
    {

        public Task< Recursos> Agregar(Recursos recursos);

        public Task <Recursos> Modificar (Recursos recursos);  

        public  Task<Recursos> Eliminar (Recursos recursos);

        public Task<IEnumerable<Recursos>> GetOne(int id);

        public Task<IEnumerable<Recursos>> GetAll();
    }
}
