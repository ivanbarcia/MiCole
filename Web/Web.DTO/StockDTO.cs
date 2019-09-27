using eDrago.Enums;
using System;

namespace eDrago.DTO
{
    public class StockDTO
    {
        public int Orden { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal? Valor { get; set; }
    }
}
