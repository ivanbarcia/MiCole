using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    [Table("FuncionRol")]
    public class FuncionRol : AuditableEntity
    {
        public int FuncionId { get; set; }
        
        public int RolId { get; set; }
    }
}
