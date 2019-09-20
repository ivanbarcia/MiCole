using eDrago.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class DetalleMovimientoFondoDTO
    {
        [Display(ResourceType = typeof(Global), Name = "NumeroOperacion")]
        public int oper_numero { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(ResourceType = typeof(Global), Name = "TipoOperacion")]
        public string Tipo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Estado")]
        public string Estado { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Cuenta")]
        public string Cuenta { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Especie")]
        public string Especie { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Moneda")]
        public string Moneda { get; set; }

        [Display(Name = "Cuotas Partes")]
        [DisplayFormat(DataFormatString = "{0:N4}", ApplyFormatInEditMode = true)]
        public decimal CantidadCuotasPartes { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Monto")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Monto { get; set; }

        [Display(Name = "Valor Cuota")]
        [DisplayFormat(DataFormatString = "{0:N4}", ApplyFormatInEditMode = true)]
        public decimal ValorCuota { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaAlta")]
        public DateTime FechaAlta { get; set; }
    }
}
