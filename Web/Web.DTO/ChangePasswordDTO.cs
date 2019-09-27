using eDrago.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class ChangePasswordDTO
    {
        public string Titulo { get; set; }
        public string Requisitos { get; set; }
    }
}
