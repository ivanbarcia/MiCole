using System;
using System.Collections.Generic;

namespace eDrago.DTO
{
    public class UsuarioDTO : AccionDTO
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public int EmpresaId { get; set; }
        public string DescripcionCompleta
        {
            get { return string.Format("{0} - {1}", NombreUsuario, NombreCompleto); }
            set { }
        }
        public string ContrasenaVieja { get; set; }
        public string Contrasena { get; set; }
        public string usua_codigo { get; set; }
        public string GrupoAD { get; set; }
        public virtual ICollection<RolUsuarioDTO> RolesUsuario { get; set; }
    }

    public class RolUsuarioDTO : AccionDTO
    {
        public int RolId { get; set; }

        public int UsuarioId { get; set; }
    }
}
