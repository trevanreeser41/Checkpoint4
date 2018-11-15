using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table ("_Instrument")]
    public class Instrument
    {
        [Key]
        public int InstrumentID { get; set; }
        public string Description { get; set; }
        public string Type{ get; set; } //true if new, false if used
        public int Price { get; set; }
        public int ClientID { get; set; }
        public string Image { get; set; }
    }
}