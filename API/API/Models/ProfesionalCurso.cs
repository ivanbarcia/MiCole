using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("ProfesionalCursos")]
    public class ProfesionalCurso : AuditableEntity
    {
        public int ProfesionalId { get; set; }
        public int CursoId { get; set; }

        public virtual Profesional Profesional { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
