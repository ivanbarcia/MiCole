using eDrago.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class FondoDatosDTO
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }

        public decimal ValorCuotaParte { get; set; }
        public decimal TotalMonto { get; set; }
        public decimal TotalCP { get; set; }

        public int CuentaMonetaria { get; set; }
        public int CuentaFondo { get; set; }

        public decimal TasaObjetivo { get; set; }
        public decimal RendimientoActual { get; set; }
    }
}
