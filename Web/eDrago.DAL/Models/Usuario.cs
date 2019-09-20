using eDrago.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    [Table("Usuarios")]
    public class Usuario : AuditableEntity
    {
        [Display(ResourceType = typeof(Global), Name = "Usuario")]
        [Required(ErrorMessageResourceName = "NombreUsuario_Requerido", ErrorMessageResourceType = typeof(Global))]
        //[Remote("UsuarioExist", "Usuario", HttpMethod = "POST", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Usuario_Exist")]
        public string NombreUsuario { get; set; }

        [Display(ResourceType = typeof(Global), Name = "NombreCompleto")]
        public string NombreCompleto { get; set; }

        public int EmpresaId { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public string DescripcionCompleta
        {
            get { return string.Format("{0} - {1}", NombreUsuario, NombreCompleto); }
            set { }
        }

        [DataType(DataType.Password)]
        [NotMapped]
        [ScaffoldColumn(false)]
        public string ContrasenaVieja { get; set; }

        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        public string usua_codigo { get; set; }

        public string GrupoAD { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public virtual ICollection<RolUsuario> RolesUsuario { get; set; }

    }

    public class Login
    {
        [Display(ResourceType = typeof (Global), Name = "Usuario")]
        [Required(ErrorMessageResourceName = "NombreUsuario_Requerido", ErrorMessageResourceType = typeof(Global))]
        public string UserName { get; set; }

        [Display(ResourceType = typeof (Global), Name = "Contrasena")]
        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceName = "Contrasena_Requerido", ErrorMessageResourceType = typeof(Global))]
        public string Password { get; set; }

        [Display(ResourceType = typeof (Global), Name = "RememberMe")]
        public bool RememberMe { get; set; }
    }

    public class AuthenticationDTO
    {
        public string token { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
    }

    public class JSONLogin
    {
        public ClienteLogin login { get; set; }
        public AuthenticationDTO authentication { get; set; }
    }
}


