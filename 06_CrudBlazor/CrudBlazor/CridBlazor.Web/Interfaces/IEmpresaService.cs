using CrudBlazor.Shared.Models;

namespace CrudBlazor.Web.Interfaces
{
    public interface IEmpresaService
    {
        Task<List<Empresa>> GetAllAsync();
    }
}