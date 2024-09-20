using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;

public static class UsuarioEndpoints
{
    public static void AddUsuarioEndpoints(this WebApplication app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }
}

//video 2 minuto 15:30