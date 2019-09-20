using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CursoAsignaturas")]
    public class CursoAsignatura : AuditableEntity
    {
        public int CursoId { get; set; }
        public int AsignaturaId { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Asignatura Asignatura { get; set; }
    }
}
