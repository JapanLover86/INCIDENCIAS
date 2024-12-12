using Control.Data;
using Control.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Control.Repositorio
{
    public class UsuariosRepositorio : IUsuarioRepositorio
    {
        public readonly AplicacionDbContext contextodb;

        public UsuariosRepositorio(AplicacionDbContext dbContext)
        {
            contextodb = dbContext;
        }

        public async Task<Usuario> Agregar(Usuario usuario)
        {
            await contextodb.Usuarios.AddAsync(usuario);
            await contextodb.SaveChangesAsync();
            return usuario;

        }

        public async Task<Usuario> Eliminar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario), "El usuario no debe ser nulo");
            }

            try
            {
                contextodb.Usuarios.Remove(usuario);
                await contextodb.SaveChangesAsync();
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario con ID {usuario.IdUsuario}", ex);
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await contextodb.Usuarios.ToListAsync();
        }

        public async Task<IEnumerable<Usuario>> GetOne(int id)
        {
            var usuario = await contextodb.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == id);
            if (usuario == null)
            {
                throw new KeyNotFoundException($"No se encontró un usuario con el ID {id}");
            }
            return (IEnumerable<Usuario>)usuario;
        }

        public async Task<Usuario> Modificar(Usuario usuario)
        {
            var modificarUsuario = await contextodb.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == usuario.IdUsuario);
            if(modificarUsuario == null)
            {
                throw new KeyNotFoundException($"No se encontró un usuario con el ID");
            }
            try
            {
                contextodb.Usuarios.Update(usuario);
                await contextodb.SaveChangesAsync();
                return usuario;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error al modificar el usuario con ID {usuario.IdUsuario}", ex);
            }
        }
    }
}
