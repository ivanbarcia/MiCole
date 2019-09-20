using eDrago.Enums;
using eDrago.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class BonoDTO
    {
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Cuenta_Requerida")]
        public string Cuenta { get; set; }

        [NotMapped]
        public string CuentaText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Bono_Requerido")]
        public string Bono { get; set; }

        [NotMapped]
        public string BonoText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Nominales_Requeridos")]
        public int Nominales { get; set; }

        public string Tipo { get; set; }
    }
}
