using eDrago.Resources;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class FormularioContraseniaDTO
    {
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "NroDocumento_Requerido")]
        public string CUIT { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "FechaNacimiento_Requerida")]
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Fecha_Invalida")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Celular_Requerido")]
        [RegularExpression(@"^(\d{4}-\d{6})$", ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Celular_Incorrecto")]
        public string Celular { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Email_Requerido")]
        [EmailAddress(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Email_Invalido")]
        public string Email { get; set; }

        [NotMapped]
        public string Nombre { get; set; }
    }
}
