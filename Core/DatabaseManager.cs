using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LLWS.Core
{
    class DatabaseManager
    {

        public DatabaseManager()
        {

        }

        /*
         * Retourne une chaîne de caractère stockées dans le fichier App.config pour éviter les redondances.
         * Il suffira s'instancier DatabaseManager() pour accéder aux opérations.
         */
        public string GetConnectionStringByName(string name)
        {
            string connectionString = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings != null)
                connectionString = settings.ConnectionString;

            return connectionString;
        }
    }


}
