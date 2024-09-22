using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Rol
{
    [Key]
    [Required]
    public Guid IdRol {get; set; } = Guid.NewGuid();
    
    [Required]
    [StringLength(50)]
    public string Nombre {get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string Habilitado {get; set; } = string.Empty;
    
    [Required]
    public int FechaCreacion {get; set; }
    
    public List<Usuario> Usuarios {get; set; } = new List<Usuario>();

    public Rol(string nombre, string habilitado, int fechaCreacion )
    {
        this.Nombre = nombre;
        this.Habilitado = habilitado;
        this.FechaCreacion = fechaCreacion;
    }
}