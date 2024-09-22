using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Usuario
{
    [Key]
    [Required]
    public Guid IdUsuario {get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Nombre {get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string Email {get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    public string Usuari {get; set; } = string.Empty;
    
    [Required]
    public int Contraseña {get; set; }
    
    [Required]
    [StringLength(50)]
    public string Habilitado {get; set; } = string.Empty;
    
    [Required]
    public int FechaCreacion {get; set; }
    
    public List<Rol> Roles {get; set; } = new List<Rol>();

    public Usuario(string nombre, string email, string usuari, int contraseña, string habilitado, int fechaCreacion )
    {
        this.Nombre = nombre;
        this.Email = email;
        this.Usuari = usuari;
        this.Contraseña = contraseña;
        this.Habilitado = habilitado;
        this.FechaCreacion = fechaCreacion;
    }
}
