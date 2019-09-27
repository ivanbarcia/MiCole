namespace eDrago.DTO
{
    public class SaldosPorClienteDTO
    {
        public string Tipo { get; set; }
        public string Depositante { get; set; }
        public int Comitente { get; set; }
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public double? Cotizacion { get; set; }
        public string FechaCotizacion { get; set; }
        public double Saldo { get; set; }
        public double? SaldoValorizado { get; set; }
        public string Cliente { get; set; }
        public string Cotiz { get; set; }
        public string SaldoVal { get; set; }
        public string Saldo_string { get; set; }
    }

    public class SaldosPorCliente_GraficoDTO
    {
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public double? SaldoValorizado { get; set; }
    }
}
