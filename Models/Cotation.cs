using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{
    /*
     * Cette classe permet d'instancier une nouvelle cotation récupérée depuis un JSON.
     */
    class Cotation
    {
        public int id { get; set; }
        public string isin_code { get; set; }
        public DateTime stock_date { get; set; }
        public double stock_opening_value { get; set; }
        public double stock_closing_value { get; set; }
        public double stock_highest_value { get; set; }
        public double stock_lowest_value { get; set; }
        public int stock_volume { get; set; }
        public string full_name { get; set; }
        public string ticker_code { get; set; }
    }
}
