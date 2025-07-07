using CrudBlazor.Shared.Models;

namespace CrudBlazor.Web.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetAllAsync();
    }
}