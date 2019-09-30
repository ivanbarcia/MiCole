using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Notificaciones")]
    public class Notificacion : AuditableEntity
    {
        public int UsuarioEmisorId { get; set; }
        public int UsuarioReceptorId { get; set; }
        public string Mensaje { get; set; }
        public bool MarcaLeido { get; set; }
        public string FechaHoraLeido { get; set; }
    }
}
