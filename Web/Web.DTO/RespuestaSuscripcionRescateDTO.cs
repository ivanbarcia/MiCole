using eDrago.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class RespuestaSuscripcionRescateDTO
    {
        public int err { get; set; }
        public string err_msg { get; set; }
        public int sfon_id { get; set; }
    }
}
