using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Shared.Models;

namespace CrudBlazor.Api.Data
{
    public class CrudBlazorApiContext : DbContext
    {
        public CrudBlazorApiContext(DbContextOptions<CrudBlazorApiContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = default!;
        public DbSet<Empresa> Empresa { get; set; } = default!;
        public DbSet<UsuarioEmpresa> UsuarioEmpresa { get; set; } = default!;
    }
}