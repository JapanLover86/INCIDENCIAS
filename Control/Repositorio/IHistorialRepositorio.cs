using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IHistorialRepositorio
    {
        public Task<HistorialIncidencias> Agregar (HistorialIncidencias historialIncidencias);

        public Task<HistorialIncidencias> Modificar (HistorialIncidencias historialIncidencias);

        public Task<HistorialIncidencias> Eliminar (HistorialIncidencias historialIncidencias);

        public Task<IEnumerable<HistorialIncidencias>> GetOne(int id);

        public Task<IEnumerable<HistorialIncidencias>> GetAll();

    }
}
