using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    public class TVBarHistory
    {
        //status code.Expected values: ok | error | no_data
        public string s { get; set; }

        //Error message. Should be present only when s = 'error'
        public string errmsg { get; set; }

        //Bar time. Unix timestamp (UTC)
        public long[] t { get; set; }
        
        //Closing price
        public double[] c { get; set; }

        //Opening price (optional)
        public double[] o { get; set; }

        //High price (optional)
        public double[] h { get; set; }

        //Low price (optional)
        public double[] l { get; set; }

        //Volume (optional)
        public long[] v { get; set; }

        //Time of the next bar if there is no data (status code is no_data ) in the requested period(optional)
        public long nextTime { get; set; }
    }
}
