using eDrago.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class SimuladorDTO
    {
        public decimal Cotizacion { get; set; }

        [Required(ErrorMessageResourceName = "ImporteRequerido", ErrorMessageResourceType = typeof(Global))]
        public decimal Importe1 { get; set; }

        [Required(ErrorMessageResourceName = "ImporteRequerido", ErrorMessageResourceType = typeof(Global))]
        public decimal Importe2 { get; set; }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        public IList<string> Fondos { get; set; }
    }
}
