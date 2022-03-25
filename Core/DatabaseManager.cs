using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LLWS.Core
{
    class DatabaseManager
    {

        private string ConnectionString = null;
        private bool isConnectionOpen = false;
        private MySqlConnection connection;

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

        public void openNewConnection()
            // Retourne une nouvelle instance de connexion à la base de données.
        {
            try
            {
                this.connection = new MySqlConnection(this.GetConnectionStringByName("main"));
                this.connection.Open();
                Console.WriteLine("Connexion à la base de données établie");
               

            } catch(Exception e)
            {
                Console.WriteLine("Erreur : " + e);
            }
           
        }

        public MySqlConnection GetMySqlConnection()
        {
            return this.connection;
        }




    }


}
