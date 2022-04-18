using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{
   /// <summary>
   /// Objet Cotation qui sera instancié pour stocker les informations d'une cotation récupéré au préalable dans la db.
   /// </summary>
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
