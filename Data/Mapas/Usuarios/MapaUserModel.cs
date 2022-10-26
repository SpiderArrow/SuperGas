using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapas.Usuarios
{
    public class MapaUserModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contraseña debe tener al menos {2} dígitos.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "*La contraseña de confirmación no es igual a la ingresada.")]
        public string ConfirmPassword { get; set; }

        public int SucursalId { get; set; }
        public string Privilegios { get; set; }
    }
}
