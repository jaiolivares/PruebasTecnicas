using CrudBlazor.Api.Data;
using CrudBlazor.Api.Interfaces.Repositories;
using CrudBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Api.Repositories
{
    public class UsuarioRepository(CrudBlazorApiContext _context) : IUsuarioRepository
    {
        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _context.Usuario.ToListAsync();
        }
    }
}