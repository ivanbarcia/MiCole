using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Tutores")]
    public class Tutor : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string FechaNacimiento { get; set; }

        public Alumno Alumno { get; set; }
    }
}
