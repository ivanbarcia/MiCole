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
        public string Descripcion { get; set; }
        public bool Autorizado { get; set; }

        public Alumno Alumno { get; set; }
        public Profesional Profesional { get; set; }
        public Tutor Tutor { get; set; }
    }
}
