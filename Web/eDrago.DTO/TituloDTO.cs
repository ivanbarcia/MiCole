using eDrago.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DTO
{
    public class TituloDTO
    {
        public string Especie { get; set; }

        public string Emisor { get; set; }

        public string Calificacion { get; set; }

        public string Instrumento { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public double Precio { get; set; }

        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public double TasaRendimiento { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Vencimiento { get; set; }
    }
}
