using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Roles;

public class RolEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/rol", ([FromServices] IRolService rolService) =>
        {
            return Results.Ok(rolService.GetRoles());
        });
    }
}

