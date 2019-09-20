using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
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
