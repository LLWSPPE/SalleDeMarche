using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLWS.Core;
using LLWS.Models;

namespace LLWS.Models
{
    /// <summary>
    /// Classe statique contenant la liste des cotations du jour. Instanciée une fois pour éviter d'appeler l'API plusieurs fois.
    /// </summary>
    static class CotationsDuJour
    {
        public static List<Cotation> ListeCotation { get; set; }

    }
}
