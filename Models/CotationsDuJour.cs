using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLWS.Core;
using LLWS.Models;

namespace LLWS.Models
{
    /*
     * Cette classe stocke les cotations du jour récupérée dans la base de données.
     * Cela permet de ne pas faire un appel à l'API pour charger toutes les cotations à chaque fois.
     */
    static class CotationsDuJour
    {
        public static List<Cotation> ListeCotation { get; set; }

    }
}
