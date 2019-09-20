using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    public class TVGroup
    {
        public string[] symbol { get; set; }
        public string[] description { get; set; }

        //Mercado en el que opera
        //Both of these fields are expected to have a short name of the exchange where this symbol is traded.
        //The name will be displayed in the chart legend for this symbol.
        public string exchange_listed { get; set; }
        public string exchange_traded { get; set; }

        //MinimalPossiblePriceChange = minmov / pricescale
        public int minmovement { get; set; }
        
        //Para precios comunes: 0
        public int minmovement2 { get; set; }
        
        //Para precios comunes: false o no incluirlo
        public double fractional { get; set; }
        
        //Cantidad de decimales (10^number-of-decimal-places), si van 2 decimales, el valor deber ser 100
        public decimal[] pricescale { get; set; }

        //Si tiene datos en minutos
        //If it's false then all buttons for intraday resolutions will be disabled for this particular symbol.
        //If it is set to true, all resolutions that are supplied directly by the datafeed must be provided in intraday_multipliers array.
        public bool has_intraday { get; set; }

        //Boolean showing whether the symbol includes volume data or not.
        public bool[] has_no_volume { get; set; }
        
        //Tipo de instrumento (accion, futuro, etc)
        public string[] type { get; set; }

        //It's an unique identifier for this particular symbol in your symbology. 
        //If you specify this property then its value will be used for all data requests for this symbol
        public string[] ticker { get; set; }

        //Timezone of the exchange for this symbol
        public string timezone { get; set; }

        //Trading hours for this symbol
        public string session_regular { get; set; }

        //Resolution or time interval is a time period of one bar. 
        //The Charting Library supports intraday resolutions (seconds, minutes, hours) and DWM resolutions (daily, weekly, monthly)
        public string[] supported_resolutions { get; set; }

        //The boolean value showing whether the library should filter bars using the current trading session.
        //If false, bars will be filtered only when the library builds data from another resolution or if has_empty_bars was set to true.
        //If true, then the Library will remove bars that don't belong to the trading session from your data.
        public bool force_session_rebuild { get; set; }

        //The boolean value showing whether data feed has its own daily resolution bars or not.
        //If has_daily = false then Charting Library will build the respective resolutions using 1-minute bars by itself.
        //If not, then it will request those bars from the data feed.
        public bool has_daily { get; set; }

        //Periodos soportados, solo si has_intraday es verdadero
        public string[] intraday_multipliers { get; set; }

        //Integer showing typical volume value decimal places for a particular symbol. 
        //0 means volume is always an integer. 1 means that there might be 1 numeric character after the comma.
        //Default: 0
        public int volume_precision { get; set; }

        //The boolean value showing whether data feed has its own weekly and monthly resolution bars or not
        //Default: false
        public bool has_weekly_and_monthly { get; set; }

        //The boolean value showing whether the library should generate empty bars in the session when there is no data from the data feed for this particular time.
        //Default: false
        public bool has_empty_bars { get; set; }
    }
}
