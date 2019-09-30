using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("Asignaturas")]
    public class Asignatura : AuditableEntity
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
