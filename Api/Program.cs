using Api.Funcionalidades;
using Api.Persistencia;
using Carter;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserApiDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Escuela")));

builder.Services.AddCarter();
builder.Services.AddServiceManager();
builder.Services.AddRepositoryManager();

var opciones = new DbContextOptionsBuilder<UserApiDBContext>();

opciones.UseNpgsql(builder.Configuration.GetConnectionString("Escuela"));

var context = new UserApiDBContext(opciones.Options);

context.Database.Migrate();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarter();

app.Run();