namespace Aplicacion.Dominio;
public class Rol
{
    public Guid IdRol {get; set; } = Guid.NewGuid();
    public string Nombre {get; set; } = string.Empty;
    public string Habilitado {get; set; } = string.Empty;
    public int FechaCreacion {get; set; }
    public List<Usuario> Usuarios {get; set; } = new List<Usuario>();
}