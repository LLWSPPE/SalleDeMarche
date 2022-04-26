using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{
    /// <summary>
    /// Cette classe stocke l'utilisateur récupéré lors de la connexion (session)
    /// Elle est statique dont accessible tout au long du cycle de vie de l'application
    /// Cette classe statique permet de créer une "Session" ou les informations de l'utilisateur de l'application est stockée.
    /// </summary>
    public static class User
        {
            public static int id { get; set; }
            public static string email { get; set; }
            public static string password { get; set; }
            public static string first_name { get; set; }
            public static string last_name { get; set; }
            public static DateTime register_date { get; set; }
            public static int responsable { get; set; }
            public static int admin { get; set; }
            public static int suspendu { get; set; }
            public static object dateDebut { get; set; }
            public static object dateFin { get; set; }
            public static double budget { get; set; }

            /*
             * Le token de connexion est central, et permettra de vérifier qu'il est bien connecté mais également
             * de voir si il peut performer certaines actions.
             */
            public static string userToken { get; set; }

        }

}
