using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface ILaboratoriosRepositorio
    {

        public Task<Laboratorios> Agregar (Laboratorios laboratorios);

        public Task <Laboratorios> Modificar (Laboratorios laboratorios);  

        public Task<Laboratorios> Eliminar (Laboratorios laboratorios);

        public Task<IEnumerable<Laboratorios>> GetOne(int id);

        public Task< IEnumerable<Laboratorios>> GetAll();
    }
}
