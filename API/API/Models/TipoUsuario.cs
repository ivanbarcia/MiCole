using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("TipoUsuarios")]
    public class TipoUsuario : AuditableEntity
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
