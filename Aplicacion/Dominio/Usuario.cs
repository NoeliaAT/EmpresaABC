using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUsuario { get; set; }
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    public string Email { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    public string Contrasena { get; set; } = string.Empty;
    [Required]
    public bool Habilitado { get; set; }
    [Required]
    public DateTime FechaCreacion { get; set; }

    public Usuario() { }

    public Usuario(string nombre, string email, string contrasena, bool habilitado, DateTime fechaCreacion)
    {
        Nombre = nombre;
        Email = email;
        Contrasena = contrasena;
        Habilitado = habilitado;
        FechaCreacion = fechaCreacion;
    }
}