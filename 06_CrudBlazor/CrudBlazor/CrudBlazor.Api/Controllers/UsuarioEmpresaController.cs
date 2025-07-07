using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Api.Data;
using CrudBlazor.Shared.Models;

namespace CrudBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioEmpresaController : ControllerBase
    {
        private readonly CrudBlazorApiContext _context;

        public UsuarioEmpresaController(CrudBlazorApiContext context)
        {
            _context = context;
        }

        // GET: api/UsuarioEmpresa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioEmpresa>>> GetUsuarioEmpresa()
        {
            return await _context.UsuarioEmpresa.ToListAsync();
        }

        // GET: api/UsuarioEmpresa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioEmpresa>> GetUsuarioEmpresa(Guid id)
        {
            var usuarioEmpresa = await _context.UsuarioEmpresa.FindAsync(id);

            if (usuarioEmpresa == null)
            {
                return NotFound();
            }

            return usuarioEmpresa;
        }

        // PUT: api/UsuarioEmpresa/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioEmpresa(Guid id, UsuarioEmpresa usuarioEmpresa)
        {
            if (id != usuarioEmpresa.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuarioEmpresa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioEmpresaExists(id))
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

        // POST: api/UsuarioEmpresa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioEmpresa>> PostUsuarioEmpresa(UsuarioEmpresa usuarioEmpresa)
        {
            _context.UsuarioEmpresa.Add(usuarioEmpresa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuarioEmpresa", new { id = usuarioEmpresa.Id }, usuarioEmpresa);
        }

        // DELETE: api/UsuarioEmpresa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioEmpresa(Guid id)
        {
            var usuarioEmpresa = await _context.UsuarioEmpresa.FindAsync(id);
            if (usuarioEmpresa == null)
            {
                return NotFound();
            }

            _context.UsuarioEmpresa.Remove(usuarioEmpresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioEmpresaExists(Guid id)
        {
            return _context.UsuarioEmpresa.Any(e => e.Id == id);
        }
    }
}