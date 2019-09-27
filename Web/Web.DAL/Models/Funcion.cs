using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DAL.Models
{
    [Table("Funciones")]
    public class Funcion : AuditableEntity
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public string DescripcionCompleta
        {
            get { return string.Format("{0} - {1}", Codigo, Descripcion); }
            set { }
        }

        [NotMapped]
        [ScaffoldColumn(false)]
        public bool Seleccionado { get; set; }

        public virtual ICollection<FuncionRol> FuncionesRol { get; set; }
    }
}
