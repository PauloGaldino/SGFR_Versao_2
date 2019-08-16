using Microsoft.AspNetCore.Identity;
using System;

namespace SGFR_Web.Models
{
    public class PerfilUsuario : IdentityUserRole<Guid>
    {
        public string Nome { get; set; }
    }
}
