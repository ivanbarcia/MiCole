using System.ComponentModel.DataAnnotations.Schema;
using Web.DAL.Models;

namespace Web.DAL.Models
{
    [Table("ConfiguracionesHorarias")]
    public class ConfiguracionHoraria : AuditableEntity
    {
        public int ProfesionalId { get; set; }
        public int DiaSemana { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string HoraDesde { get; set; }
        public string HoraHasta { get; set; }

        public virtual Profesional Profesional { get; set; }
    }
}
