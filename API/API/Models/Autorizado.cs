using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("Autorizaciones")]
    public class Autorizacion : AuditableEntity
    {
        public string Fecha { get; set; }
        public string FechaHora { get; set; }
        public int ProfesionalId { get; set; }
        public int AlumnoId { get; set; }
        public string Descripcion { get; set; }
        public bool Autorizado { get; set; }
        public int TutorId { get; set; }

        public virtual Profesional Profesional { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
