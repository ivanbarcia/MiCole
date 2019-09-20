using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDrago.DAL.Models
{
    public class TVConfig
    {
        public string[] supported_resolutions { get; set; }
        public bool supports_group_request { get; set; }
        public bool supports_marks { get; set; }
        public bool supports_search { get; set; }
        public bool supports_timescale_marks { get; set; }
    }
}
