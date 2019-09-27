using eDrago.Resources;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class ClienteLoginDTO
    {
        public int Id { get; set; }

        public string clie_alias { get; set; }

        public string Usuario { get; set; }

        public string NombreAfip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //public Int32? Pregunta { get; set; }

        //public string Respuesta { get; set; }

        //public int Bloqueado { get; set; }

        public int IntentosFallidos { get; set; }

        public int Estado { get; set; }

        public string Mensaje { get; set; }

        public int RenovarClave { get; set; }
    }
    
    public class AuthenticationDTO
    {
        public string token { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
    }

    public class JSONLogin
    {
        public ClienteLoginDTO login { get; set; }
        public AuthenticationDTO authentication { get; set; }
    }

    public class PasswordValidationDTO
    {
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "CUIT_Requerido")]
        public string CUIT { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Password_Requerido")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Error_ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
