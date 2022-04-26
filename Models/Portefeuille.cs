using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{

    /// <summary>
    /// Objet Portefeuille qui sera instancié pour stocker les informations d'un portefeuille récupéré au préalable dans la db.
    /// </summary>
    public class Portefeuille
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string isin_code { get; set; }
        public string full_name { get; set; }
        public int quantite { get; set; }

        public double stock_closing_value { get; set; }
    }
}
