using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{
    public class Mouvement
    {

        public int id { get; set; }
        public int user_id { get; set; }
        public string type_mouvement { get; set; }
        public string isin_code { get; set; }
        public int quantite { get; set; }
        public DateTime date_mouvement { get; set; }
        public double montant { get; set; }


    }
}
