using CrudBlazor.Api.Interfaces.Repositories;
using CrudBlazor.Api.Interfaces.Services;
using CrudBlazor.Shared.Models;

namespace CrudBlazor.Api.Services
{
    public class UsuarioService(IUsuarioRepository _usuarioRepository) : IUsuarioService
    {
        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }
    }
}