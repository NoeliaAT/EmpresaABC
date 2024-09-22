using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Funcionalidades.UsuarioRol
{
    public class UsuarioRolEndpoints
    {
        
    }
}

//namespace Aplicacion.Dominio;
public class UsuarioRol
{
    public Guid IdUsuarioRol {get; set; } = Guid.NewGuid();
    public Guid IdUsuario {get; set; } = Guid.NewGuid();
    public Guid IdRol {get; set; } = Guid.NewGuid();
}