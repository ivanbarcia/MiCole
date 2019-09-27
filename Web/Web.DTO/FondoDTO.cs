using eDrago.Enums;
using eDrago.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class FondoDTO
    {
        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Fondo_Requerido")]
        public string Fondo { get; set; }

        [NotMapped]
        public string FondoText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "CuentaMonetaria_Requerida")]
        public string CuentaMonetaria { get; set; }

        [NotMapped]
        public string CuentaMonetariaText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "CuentaFondo_Requerida")]
        public string CuentaFondo { get; set; }

        [NotMapped]
        public string CuentaFondoText { get; set; }

        [Required(ErrorMessageResourceType = typeof(Global), ErrorMessageResourceName = "Importe_Requerido")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal Importe { get; set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal CuotaPartes { get; set; }

        public string Tipo { get; set; }
    }
}
