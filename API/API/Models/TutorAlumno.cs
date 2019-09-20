using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("TutorAlumnos")]
    public class TutorAlumno : AuditableEntity
    {
        public int AlumnoId { get; set; }
        public int TutorId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
