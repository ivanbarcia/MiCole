using eDrago.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class LoginDTO
    {
        public int Status { get; set; }

        public string Message { get; set; }
    }
}
