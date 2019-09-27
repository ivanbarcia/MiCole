using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    public class AuditableEntity : Entity
    {
        [ScaffoldColumn(false)]
        public int Estado { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime FechaAlta { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string UsuarioAlta { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        public DateTime? FechaModificacion { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string UsuarioModificacion { get; set; }
    }
}