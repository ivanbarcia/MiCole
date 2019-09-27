using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    [Table("operadores")]
    public class Operador : AuditableEntity
    {
        public int oper_id { get; set; }
        
        [Required]
        public string oper_alias { get; set; }
        public string oper_nombre { get; set; }
        public string oper_legajo { get; set; }
        
        [Required]
        public bool oper_opera { get; set; }
        public string usua_alta { get; set; }
        public string usua_modif { get; set; }
        public DateTime? oper_falta { get; set; }
        public DateTime? oper_fmodif { get; set; }
        
        [Required]
        public bool es_trader { get; set; }

    }
}
