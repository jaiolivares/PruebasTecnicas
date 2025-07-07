using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Api.Data;
using CrudBlazor.Shared.Models;
using CrudBlazor.Api.Interfaces.Services;

namespace CrudBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController(CrudBlazorApiContext _context, IUsuarioService _usuarioService) : ControllerBase
    {
        //private readonly CrudBlazorApiContext _context;

        //public UsuariosController(CrudBlazorApiContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            var responseApi = new ResponseApi<IEnumerable<Usuario>>();
            try
            {
                var usuarios = await _usuarioService.GetAllAsync();

                if (usuarios == null || !usuarios.Any())
                {
                    return NotFound();
                }

                responseApi.Success = true;
                responseApi.Value = usuarios;

                return Ok(responseApi);
            }
            catch (Exception ex)
            {
                responseApi.Success = false;
                responseApi.Message = ex.Message;

                return StatusCode(StatusCodes.Status500InternalServerError, responseApi);
            }
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
    }
}