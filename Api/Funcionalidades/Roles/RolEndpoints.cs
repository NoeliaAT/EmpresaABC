using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Roles;

public static class RolEndpoints
{
    public static void MapRolEndpoints(this WebApplication app)
    {
        app.MapGet("/api/rol", ([FromServices] IRolService rolService) =>
        {
            return Results.Ok(rolService.GetRoles());
        });
    }
}