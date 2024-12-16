using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public interface ILaboratoriosRepositorio
    {

        public Task<Laboratorios> Agregar (Laboratorios laboratorios);

        public Task <Laboratorios> Modificar (Laboratorios laboratorios);  

        public Task<Laboratorios> Eliminar (Laboratorios laboratorios);

        Task<Laboratorios> GetOne(int id);

        public Task< IEnumerable<Laboratorios>> GetAll();
    }
}
