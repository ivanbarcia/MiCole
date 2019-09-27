using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DAL.Models
{
    public class Alumno : AuditableEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string FechaNacimiento { get; set; }
    }
}
