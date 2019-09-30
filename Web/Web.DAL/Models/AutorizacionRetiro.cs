using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("AutorizacionesRetiro")]
    public class AutorizacionRetiro : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Parentesco { get; set; }

        public Alumno Alumno { get; set; }
        public Tutor Tutor { get; set; }
    }
}
