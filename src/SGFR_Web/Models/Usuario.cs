using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SGFR_Web.Models
{
    public class Usuario : IdentityUser
    {
        public string  Nome { get; set; }
    }
}
