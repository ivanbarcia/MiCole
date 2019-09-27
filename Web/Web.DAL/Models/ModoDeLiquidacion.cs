using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    [Table("ModosDeLiquidacion")]
    public class ModoDeLiquidacion : AuditableEntity
    {
        [Required]
        [StringLength(3)]
        public string Alias {get; set;}

        [Required]
        [StringLength(50)]
        public string Descripcion {get; set;}
    }
}
