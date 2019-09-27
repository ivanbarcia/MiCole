using eDrago.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class HistoriaMovimientosDTO
    {
        public int Id { get; set; }

        public string Estado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(ResourceType = typeof(Global), Name = "Fecha")]
        public DateTime FechaOrigen { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaVence { get; set; }

        public string Especie { get; set; }
        public string TipoEspecie { get; set; }
        public string Descripcion { get; set; }
        public string TipoOperacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:N4}", ApplyFormatInEditMode = true)]
        public Decimal CantidadVN { get; set; }

        [DisplayFormat(DataFormatString = "{0:N4}", ApplyFormatInEditMode = true)]
        public Double Precio { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public Double Monto { get; set; }
    }
}
