using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IUsuarioRepositorio
    {
        public Task <Usuario> Agregar (Usuario usuario);

        public Task<Usuario> Modificar (Usuario usuario);

        public Task<Usuario> Eliminar (Usuario usuario);  

        public Task<IEnumerable<Usuario>> GetOne(int  id);

        public Task <IEnumerable<Usuario>> GetAll();

    }
}
