using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    public class AuditableEntity : Entity
    {
        [IgnoreDataMember]
        [ScaffoldColumn(false)]
        public int Estado { get; set; }

        [IgnoreDataMember]
        [ScaffoldColumn(false)]
        public DateTime FechaNovedad { get; set; }

        [IgnoreDataMember]
        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string UsuarioNovedad { get; set; }
    }
}
