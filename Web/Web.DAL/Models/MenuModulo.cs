using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    [Table("Menues")]
    public class MenuModulo : AuditableEntity
    {
        public string Descripcion { get; set; }
    }
}
