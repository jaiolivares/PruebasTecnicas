using CrudBlazor.Shared.Models;

namespace CrudBlazor.Api.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}