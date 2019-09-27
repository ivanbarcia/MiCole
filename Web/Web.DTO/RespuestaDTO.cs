using eDrago.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class RespuestaDTO
    {
        public int Value { get; set; }
        public string Mensaje { get; set; }
    }
}
