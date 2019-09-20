namespace eDrago.DTO
{
    public class SaldosPorClienteMonetariasDTO
    {
        public string Descripcion { get; set; }
        public double Saldo { get; set; }
        public double? Cotizacion { get; set; }
        public double? SaldoValorizado { get; set; }
        public string FechaCotizacion { get; set; }
        public string Especie { get; set; }
        public string Saldo_string { get; set; }
        public string Cotizacion_string { get; set; }
        public string SaldoValorizado_string { get; set; }
    }
}
