using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    [Table("ModuloFuncion")]
    public class ModuloFuncion : AuditableEntity
    {
        public int RolId { get; set; }
        public int ModuloId { get; set; }
        public int FuncionId { get; set; }
        public bool Seleccionado { get; set; }
    }

    public class ModuloFuncionViewModel
    {
        public int[][] ModuloFuncionIds { get; set; }
        public int[][] ModuloFuncionChecks { get; set; }
    }
}
