using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Resources;

namespace Web.DAL.Models
{
    [Table("Entidades")]
    public class Entidad : AuditableEntity
    {
        [Display(ResourceType = typeof (Global), Name = "Codigo")]
        public string Codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Descripcion")]
        public string Descripcion { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public string DescripcionCompleta
        {
            get { return string.Format("{0} - {1}", Codigo, Descripcion); }
            set { }
        }
    }
}
