using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Web.DAL.Models
{
    [Table("reportes_almacenados")]
    public class Reporte
    {
        public DateTime fecha { get; set; }
        public int clie_alias { get; set; }
        public string espe_codigo { get; set; }
        public int? oper_numero { get; set; }
        public string tipo_reporte { get; set; }
        public Byte[] reporte { get; set; }
    }
}
