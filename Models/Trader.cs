using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{

    /// <summary>
    /// Cette classe instancie un nouvel utilisateur.
    /// La différence avec le Models/User est que cette classe est instanciable pour opérer différentes actions (listing, stockage)
    /// </summary>
    public class Trader
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime register_date { get; set; }
        public int responsable { get; set; }
        public int admin { get; set; }
        public int suspendu { get; set; }
        public object dateDebut { get; set; }
        public object dateFin { get; set; }
        public double budget { get; set; }
        public string userToken { get; set; }
    }
}
