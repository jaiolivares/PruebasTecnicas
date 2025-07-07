using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrudBlazor.Api.Data;
using CrudBlazor.Api.Interfaces.Services;
using CrudBlazor.Api.Services;
using CrudBlazor.Api.Interfaces.Repositories;
using CrudBlazor.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CrudBlazorApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CrudBlazorApiContext") ?? throw new InvalidOperationException("Connection string 'CrudBlazorApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

//app.UseCors(c => c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();