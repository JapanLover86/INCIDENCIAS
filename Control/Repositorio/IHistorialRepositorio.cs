using Control.Data.Entidades;

namespace Control.Repositorio
{
    public interface IHistorialRepositorio
    {
        Task<HistorialIncidencias> Agregar(HistorialIncidencias historialIncidencias);
        Task<HistorialIncidencias> Modificar(HistorialIncidencias historialIncidencias);
        Task<HistorialIncidencias> Eliminar(HistorialIncidencias historialIncidencias);
        Task<HistorialIncidencias> GetOne(int id);
        Task<IEnumerable<HistorialIncidencias>> GetAll();
    }
}
