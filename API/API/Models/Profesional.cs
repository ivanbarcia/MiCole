using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
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
}
