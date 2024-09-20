namespace Aplicacion.Dominio;
public class Usuario
{
    public Guid IdUsuario {get; set; } = Guid.NewGuid();
    public string Nombre {get; set; } = string.Empty;
    public string Email {get; set; } = string.Empty;
    public string Usuari {get; set; } = string.Empty;
    public int Contraseña {get; set; }
    public string Habilitado {get; set; } = string.Empty;
    public int FechaCreacion {get; set; }
    public List<Rol> Roles {get; set; } = new List<Rol>();

    public Usuario(string nombre, string email, string usuari, int contraseña, string habilitado, int fechaCreacion )
    {
        Nombre = nombre;
        Email = email;
        Usuari = usuari;
        Contraseña = contraseña;
        Habilitado = habilitado;
        FechaCreacion = fechaCreacion;
    }


}
