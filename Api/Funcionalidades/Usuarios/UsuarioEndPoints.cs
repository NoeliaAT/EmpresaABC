using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;
public class UsuarioEndPoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/usuario", ([FromServices] IUsuarioService usuarioService, Aplicacion.Dominio.Usuario usuario) =>
        {
            if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Contrasena))
            {
                return Results.BadRequest("400 Bad Request: Por favor, no deje campos vacíos o nulos.");
            }
            usuarioService.Crear(usuario);
            return Results.Created($"/api/usuario/{usuario.Id}", usuario);
        });
        
        app.MapGet("/api/Usuarios", ([FromServices] IUsuarioService usuarioService) =>
        {
            var usuarios = usuarioService.ObtenerUsuario();
            return Results.Ok(usuarios);
        });

        app.MapGet("/api/Usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, int IdUsuario) =>
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
            if (usuario == null || usuario.Count == 0)
            {
                return Results.NotFound("404 Not Found, No existe");
            }
            return Results.Ok(usuario);
        });

        app.MapPut("/api/usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, int IdUsuario, Aplicacion.Dominio.Usuario usuario) =>
        {
            var Existe = usuarioService.ObtenerUsuarioPorId(usuario.IdUsuario);
            if (Existe == null)
            {
                return Results.NotFound("404 Not Found: No se encontró usuario");
            }

            if (!string.IsNullOrEmpty(usuario.Nombre) && usuario.Nombre != Existe.Nombre)
            {
                return Results.BadRequest("400 Mala solicitud: No se permite modificar el nombre del usuario.");
            }
            rolService.Modificar(Existe);
            return Results.NoContent(); // Devuelve 204 No Content cuando la operación es exitosa
        });

        app.MapDelete("api/usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, int IdUsuario) =>
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
            if (usuario.Count == 0)
            {
                return Results.NotFound("404 No encontrado");
            }
            rolService.Eliminar(IdRol);
            return Results.NoContent();
        });
    }
}
