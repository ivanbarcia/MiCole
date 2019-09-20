using System;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class FiltrosReporteDTO
    {
        public DateTime fecha { get; set; }

        public string espe_codigo { get; set; }

        public string espe_descrip { get; set; }
    }
}
