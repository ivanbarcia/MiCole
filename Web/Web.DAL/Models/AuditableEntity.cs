using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Web.DAL.Models
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