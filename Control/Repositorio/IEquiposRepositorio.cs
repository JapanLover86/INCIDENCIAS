using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IEquiposRepositorio
    {
        public Equipos Agregar (Equipos equipos);  

        public Equipos Modificar (Equipos equipos); 

        public Equipos Eliminar (Equipos equipos);

        public Task<IEnumerable<Equipos>> GetOne(int id);

        public Task<IEnumerable<Equipos>> GetAll();

    }
}
