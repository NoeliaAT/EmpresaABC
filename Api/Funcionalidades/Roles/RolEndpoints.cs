using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Rols;

public class RolEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/rol", ([FromServices] IRolService rolService, Aplicacion.Dominio.Rol rol) =>
        {
            if (rol.Nombre == null)
            {
                return Results.BadRequest("400 Bad requests, complete los campos vacios");
            }
            rolService.Crear(rol);
            return Results.Created();
        });

        app.MapGet("/api/rol", ([FromServices] IRolService rolService) =>
        {
            var rols = rolService,ObtenerRol();
            return Results.Ok(rols);
        });

        app.MapGet("api/rol/{IdRol}", ([FromServices] IRolService rolService, int IdRol) =>
        {
            var rol = rolService.ObtenerRolPorId(IdRol);
            if (rol == null || rol.Count == 0)
            {
                return Results.NotFound("404 Not Found, No existe");
            }
            return Results.Ok(rol);
        });

        app.MapPut("/api/rol/{IdRol}", ([FromServices] IRolService rolService, int IdRol, Aplicacion.Dominio.Rol rol) =>
        {
            var Existe = rolService.ObtenerRolPorId(rol.IdRol);
            if (Existe == null)
            {
                return Results.NotFound("404 Not Found: No se encontró rol");
            }

            if (!string.IsNullOrEmpty(rol.Nombre) && rol.Nombre != Existe.Nombre)
            {
                return Results.BadRequest("400 Mala solicitud: No se permite modificar el nombre del rol.");
            }
            rolService.Modificar(Existe);
            return Results.NoContent(); // Devuelve 204 No Content cuando la operación es exitosa
            });
        
        app.MapDelete("api/rol/{IdRol}", ([FromServices] IRolService rolService, int IdRol) =>
        {
            var rol = rolService.ObtenerRolPorId(IdRol);
            if (rol.Count == 0)
            {
                return Results.NotFound("404 No encontrado");
            }
            rolService.Eliminar(IdRol);
            return Results.NoContent();
        });
    }
}