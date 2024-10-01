using Aplicacion.Dominio;

namespace Api.Funcionalidades.Rols;

public interface IRolService
{
    List<Rol> GetRols();
}

public class RolService : IRolService
{
    List<Rol> rols;

    public RolService()
    {
        rols = new List<Rol>()
        {
            new Rol("Rol1", "Habilitado1", 21122009),
            new Rol("Rol2", "Habilitado2", 21122010)
        };
    }

    public List<Rol> GetRols()
    {
        return rols;
    }
}
