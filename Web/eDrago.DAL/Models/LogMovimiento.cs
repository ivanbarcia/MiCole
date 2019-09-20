using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    [Table("LogMovimientos")]
    public class LogMovimiento : AuditableEntity
    {
        public string Controller { get; set; }
        public string Accion { get; set; }
        public string Ruta { get; set; }
        public string TipoMetodo { get; set; }
        public string Descripcion { get; set; }
    }
}