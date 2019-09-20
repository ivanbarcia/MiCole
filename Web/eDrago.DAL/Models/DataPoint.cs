using System.Runtime.Serialization;

namespace eDrago.DAL.Models
{
    [DataContract]
    public class DataPoint
    {
        public DataPoint(string label, decimal y)
        {
            this.Label = label;
            this.Y = y;
        }

        //Explicitly setting the name to be used while serializing to JSON. 
        [DataMember(Name = "label")]
        public string Label;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public decimal Y;
    }

    public class DoughnutData
    {
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public double Saldo { get; set; }
    }

    public class BarData
    {
        public string Especie { get; set; }
        public decimal Saldo { get; set; }
    }
}
