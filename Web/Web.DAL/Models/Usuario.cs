using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Usuarios")]
    public class Usuario : AuditableEntity
    {
        public int TipoUsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
