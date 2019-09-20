using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    public class TVSymbolInfo
    {
        public string name { get; set; }
        public string ticker { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string session { get; set; }
        public string exchange { get; set; }
        public string listed_exchange { get; set; }
        public string timezone { get; set; }
        public double minmov { get; set; }
        public double pricescale { get; set; }
        public double minmove2 { get; set; }
        public double fractional { get; set; }
        public bool has_intraday { get; set; }
        public string[] supported_resolutions { get; set; }
        public string[] intraday_multipliers { get; set; }
        public bool has_seconds { get; set; }
        public string[] seconds_multipliers { get; set; }
        public bool has_daily { get; set; }
        public bool has_weekly_and_monthly { get; set; }
        public bool has_empty_bars { get; set; }
        public bool force_session_rebuild { get; set; }
        public bool has_no_volume { get; set; }
        public int volume_precision { get; set; }
        public string data_status { get; set; }
        public bool expired { get; set; }
        public bool expiration_date { get; set; }
        public string sector { get; set; }
        public string industry { get; set; }
        public string currency_code { get; set; }
    }
}
