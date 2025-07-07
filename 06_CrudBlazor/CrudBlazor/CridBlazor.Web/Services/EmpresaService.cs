using CrudBlazor.Shared.Models;
using CrudBlazor.Web.Interfaces;

namespace CrudBlazor.Web.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly HttpClient _httpClient;

        public EmpresaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Empresa>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ResponseApi<List<Empresa>>>("api/Empresas");

            if (response!.Success)
            {
                return response.Value ?? new List<Empresa>();
            }
            else
            {
                throw new Exception(response.Message);
            }
        }
    }
}