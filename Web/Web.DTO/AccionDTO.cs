using eDrago.Enums;
using eDrago.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class AccionDTO
    {
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Cuenta_Requerida")]
        public string Cuenta { get; set; }

        [NotMapped]
        public string CuentaText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Accion_Requerido")]
        public string Accion { get; set; }

        [NotMapped]
        public string AccionText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Nominales_Requeridos")]
        public int Nominales { get; set; }

        public string Tipo { get; set; }
    }
}
