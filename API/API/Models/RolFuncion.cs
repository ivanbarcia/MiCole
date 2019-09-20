using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("RolFunciones")]
    public class RolFuncion : AuditableEntity
    {
        public int RolId { get; set; }
        public int FuncionId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Funcion Funcion { get; set; }
    }
}
