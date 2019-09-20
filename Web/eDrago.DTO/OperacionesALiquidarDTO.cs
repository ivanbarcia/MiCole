using System;

namespace eDrago.DTO
{
    public class OperacionesALiquidarDTO
    {
        public string TipoOperacion { get; set; }
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public string FechaConcertacion { get; set; }
        public string FechaLiquidacion { get; set; }
        public decimal Cantidad { get; set; }
        public double Precio { get; set; }
        public string Moneda { get; set; }
        public double? Monto { get; set; }
        public double Cotizacion { get; set; }
        public double? SaldoValorizado { get; set; }
        public Int32 Operacion { get; set; }
        public string Cantidad_string { get; set; }
        public string Precio_string { get; set; }
        public string Monto_string { get; set; }
        public string Cotizacion_string { get; set; }
        public string SaldoValorizado_string { get; set; }
    }
}
