using CrudBlazor.Shared.Models;
using CrudBlazor.Web.Interfaces;

namespace CrudBlazor.Web.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ResponseApi<List<Usuario>>>("api/Usuarios");

            if (response!.Success)
            {
                return response.Value ?? new List<Usuario>();
            }
            else
            {
                throw new Exception(response.Message);
            }
        }
    }
}