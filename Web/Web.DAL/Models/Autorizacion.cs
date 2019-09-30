using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Autorizaciones")]
    public class Autorizacion : AuditableEntity
    {
        public string Fecha { get; set; }
        public string FechaHora { get; set; }
        public string Descripcion { get; set; }
        public bool Autorizado { get; set; }

        public Alumno Alumno { get; set; }
        public Profesional Profesional { get; set; }
        public Tutor Tutor { get; set; }
    }
}
