using System;

namespace eDrago.DTO
{
    public class TenenciasTITDTO
    {
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public double? Cantidad { get; set; }
        public double? Saldo { get; set; }
        public string cantidad_string { get; set; }
        public string saldo_string { get; set; }
    }
}
