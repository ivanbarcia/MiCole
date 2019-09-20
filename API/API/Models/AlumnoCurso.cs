using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("AlumnoCursos")]
    public class AlumnoCurso : AuditableEntity
    {
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
