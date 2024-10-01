using Api.Funcionalidades.Rols;
using Api.Funcionalidades.Usuarios;

namespace Api.Funcionalidades;

public static class ServiceManager
{
    public static IServiceCollection AddServiceManager(this IServiceCollection services)
    {
        services.AddSingleton<IUsuarioService, UsuarioService>();
        services.AddSingleton<IRolService, RolService>();

        return services;
    }
}