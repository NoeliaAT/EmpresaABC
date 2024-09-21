using Aplicacion.Dominio;

namespace Api.Funcionalidades.Roles;

public interface IRolService
{
    List<Rol> GetRoles();
}

public class RolService : IRolService
{
    List<Rol> roles;

    public RolService()
    {
        roles = new List<Rol>()
        {
            new Rol("Rol1", "Habilitado1", 21122009),
            new Rol("Rol2", "Habilitado2", 21122010)
        };
    }

    public List<Rol> GetRoles()
    {
        return roles;
    }
}