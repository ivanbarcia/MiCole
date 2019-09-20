using eDrago.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace eDrago.DAL.Models
{
    [Table("ClientesLogin")]
    public class ClienteLogin : AuditableEntity
    {
        [Required]
        public string Usuario { get; set; }

        public string Contrasena { get; set; }

        public string clie_alias { get; set; }

        [NotMapped]
        public int Cuenta { get; set; }

        [Display(ResourceType = typeof(Global), Name = "NombreAfip")]
        public string NombreAfip { get; set; }

        public Int32? Pregunta { get; set; }

        //[Required(ErrorMessageResourceName = "RespuestaRequerida", ErrorMessageResourceType = typeof(Global))]
        public string Respuesta { get; set; }

        public int Bloqueado { get; set; }
    
        public int CantidadIntentosFallidos { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Email_Requerido")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Email_Invalido")]
        public string Email { get; set; }

        public int RenovarClave { get; set; }

        public string Celular { get; set; }

        public DateTime? FechaNacimiento { get; set; }
    }
}
