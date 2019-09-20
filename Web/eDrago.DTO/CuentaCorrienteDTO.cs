using eDrago.Enums;
using System;

namespace eDrago.DTO
{
    public class CuentaCorrienteDTO
    {
        public bool Pendiente { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        public DebitoCredito DebitoCredito { get; set; }

        public string Moneda { get; set; }

        public decimal ValorCuota { get; set; }

        public decimal CuotaPartes { get; set; }

        public decimal Importe { get; set; }
    }
}
