using eDrago.DAL.Models;
using eDrago.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class PreguntaSeguridadRecuperacionDTO
    {
        public int Value { get; set; }
        public Preguntas Preguntas { get; set; }
        public ClienteLogin Cliente { get; set; }
    }
}
