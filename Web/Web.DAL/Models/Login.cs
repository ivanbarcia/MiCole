using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Resources;

namespace Web.DAL.Models
{
    public class Login
    {
        [Display(ResourceType = typeof(Global), Name = "Usuario")]
        [Required(ErrorMessageResourceName = "NombreUsuario_Requerido", ErrorMessageResourceType = typeof(Global))]
        public string UserName { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Contrasena")]
        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceName = "Contrasena_Requerido", ErrorMessageResourceType = typeof(Global))]
        public string Password { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Login_RememberMe")]
        public bool RememberMe { get; set; }
    }
}
