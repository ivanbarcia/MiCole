using System;
using System.Collections.Generic;

namespace eDrago.DTO
{
    public class RolDTO : AuditDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public string DescripcionCompleta
        {
            get { return string.Format("{0} - {1}", Codigo, Descripcion); }
            set { }
        }

        public bool Seleccionado { get; set; }
        public string GrupoAD { get; set; }

        public virtual ICollection<RolUsuarioDTO> RolesUsuario { get; set; }
        public virtual ICollection<FuncionRolDTO> FuncionesRol { get; set; }
    }

    public class FuncionRolDTO : AuditDTO
    {
        public int FuncionId { get; set; }

        public int RolId { get; set; }
    }
}
