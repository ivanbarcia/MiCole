using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
        [Table("RolUsuario")]
    public class RolUsuario : AuditableEntity
    {
        public int RolId { get; set; }

        public int UsuarioId { get; set; }
    }

    public class RolUsuarioViewModel
    {
        public int[][] RolUsuarioIds { get; set; }
        public string Usuario { get; set; }
    }    
}
