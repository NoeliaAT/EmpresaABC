using Aplicacion.Dominio;

namespace Api.Funcionalidades.Usuarios;

public interface IUsuarioService
{
    List<Usuario> GetUsuarios();
}

public class UsuarioService : IUsuarioService
{
    List<Usuario> usuarios;

    public UsuarioService()
    {
        usuarios = new List<Usuario>()
        {
            new Usuario("Nombre1", "email1", "usuari1", 123, "Habilitado1", 21122005),
            new Usuario("Nombre2", "email2", "usuari2", 321, "Habilitado2", 30042007),
        };
    }

    public List<Usuario> GetUsuarios()
    {
        return usuarios;
    }
}