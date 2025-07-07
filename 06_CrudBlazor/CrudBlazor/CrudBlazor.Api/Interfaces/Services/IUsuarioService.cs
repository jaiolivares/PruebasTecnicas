using CrudBlazor.Shared.Models;

namespace CrudBlazor.Api.Interfaces.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}