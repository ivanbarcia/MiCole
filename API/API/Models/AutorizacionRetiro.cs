using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("AutorizacionesRetiro")]
    public class AutorizacionRetiro : AuditableEntity
    {
        public int AlumnoId { get; set; }
        public int TutorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Parentesco { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
