using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IEquiposRepositorio
    {
        public Task <Equipos> Agregar (Equipos equipos);  

        public Task <Equipos> Modificar (Equipos equipos); 

        public Task <Equipos> Eliminar (Equipos equipos);

        public Task <IEnumerable<Equipos>> GetOne(int id);

        public Task<IEnumerable<Equipos>> GetAll();

    }
}
