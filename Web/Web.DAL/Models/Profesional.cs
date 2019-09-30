using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Profesionales")]
    public class Profesional : AuditableEntity
    {
        public int TipoProfesionalId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string FechaNacimiento { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFin { get; set; }

        public virtual TipoProfesional TipoProfesional { get; set; }
    }

    [Table("ProfesionalCursos")]
    public class ProfesionalCurso : AuditableEntity
    {
        public int ProfesionalId { get; set; }
        public int CursoId { get; set; }

        public virtual Profesional Profesional { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
