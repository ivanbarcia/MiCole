using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Cursos")]
    public class Curso : AuditableEntity
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public Alumno Alumno { get; set; }
    }

    [Table("CursoAsignaturas")]
    public class CursoAsignatura : AuditableEntity
    {
        public int CursoId { get; set; }
        public int AsignaturaId { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Asignatura Asignatura { get; set; }
    }
}
