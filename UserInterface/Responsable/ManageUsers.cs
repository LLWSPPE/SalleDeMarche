using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LLWS.Core;
using Flurl.Http;

namespace LLWS.UserInterface.Responsable
{
    public partial class ManageUsers : Form
    {

        public string response;
        public ManageUsers(string response)
        {
            InitializeComponent();
            this.response = response;
            setUpDataGridView();
            this.Text = "Gestion des utilisateurs";
        }

        #region "Fonctions d'initialisation des composants"
        private void setUpDataGridView()
        {

            dtgUsers.ColumnCount = 9;

            dtgUsers.Columns[0].Name = "id";
            dtgUsers.Columns[1].Name = "Email";
            dtgUsers.Columns[2].Name = "Prénom";
            dtgUsers.Columns[3].Name = "Nom";
            dtgUsers.Columns[4].Name = "Inscription";
            dtgUsers.Columns[5].Name = "Responsable ?";
            dtgUsers.Columns[6].Name = "Administrateur ?";
            dtgUsers.Columns[7].Name = "Suspendu ?";
            dtgUsers.Columns[8].Name = "Budget";

            DataGridViewButtonColumn colonneButton = new DataGridViewButtonColumn();
            colonneButton.HeaderText = "Actions";
            colonneButton.Text = "Gérer";
            colonneButton.Name = "btnManageUser";
            colonneButton.UseColumnTextForButtonValue = true;
            dtgUsers.Columns.Add(colonneButton);

            dtgUsers.RowHeadersVisible = true;

            remplirDataGridView();


        }


        /*
         * On récupére les données de la réponse JSON reçue.
         * On la désérialise : on récupère chaque propriété du JSON qu'on instancie en nouvel Object Trader 
         * Chaque cotation sera placée dans une Liste de Cotation, et on itèrera à travers celle-ci pour remplir les données du datagridview
         */
        private void remplirDataGridView()
        {
            var datas = JsonConvert.DeserializeObject<List<Trader>>(this.response);

            foreach (Trader trader in datas)
            {

                dtgUsers.Rows.Add(
                    trader.id.ToString(),
                    trader.email.ToString(),
                    trader.first_name.ToString(),
                    trader.last_name.ToString(),
                    trader.register_date.ToString(),
                    trader.responsable.ToString(),
                    trader.admin.ToString(),
                    trader.suspendu.ToString(),
                    trader.budget.ToString()
               );
            }
        }

        /*
         * Cette fonction définit si un click est performé sur une cellule et colonne particulier.
         * Si la colonne correspond à la 9 ème (Actions) alors cela performe une action (appel asynchrone pour gérer un utilisateur)
         */
        private async void dtgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int userId = Int32.Parse(dtgUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                string route = APIManager.API_ROUTES_GET_SPECIFIC_USER + userId.ToString();
                string routeUtilisateurMouvement = APIManager.API_BASE_URL + "/users/" + userId.ToString() + "/mouvements/";

                JToken reponse = await APIManager.recevoirData(route);

                //On désérialise le json en Trader
                Trader traderToManage = JsonConvert.DeserializeObject<Trader>(reponse.SelectToken("result[0]").ToString());

                if(reponse.SelectToken("status").ToString() == "SUCCESS")
                {

                    JToken reponseMouvements = await APIManager.recevoirData(routeUtilisateurMouvement);
                    if (reponseMouvements.SelectToken("status").ToString() == "SUCCESS")
                    {
                        string mouvementsString = reponseMouvements.SelectToken("mouvements").ToString();
                        ManageUserWindows gererUser = new ManageUserWindows(traderToManage, mouvementsString);
                        gererUser.Show();
                    }
                    else
                    {
                        MessageBox.Show("Il y a eu une erreur lors de la récupération des opérations de cet utilisateur.");
                    }

                        
                } else
                {
                    MessageBox.Show("Il y a eu une erreur lors de la récupération des informations de cet utilisateur.");
                }
              

             }

        }

        #endregion

    }
}
