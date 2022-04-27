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
using Flurl.Http;
using LLWS.Core;

namespace LLWS.UserInterface.Responsable
{
    public partial class ManageUserWindows : Form
    {

        private string response { get; set; }
        private Trader trader { get; set; }

        private string mouvements { get; set; }

        public ManageUserWindows(Trader trader, string mouvements)
        {
            InitializeComponent();
            this.trader = trader;
            this.mouvements = mouvements;
            this.MaximizeBox = false;
            setUpComposants();
            this.Text = "Gestion de l'utilisateur "+trader.first_name+" "+trader.last_name+" ("+trader.id+")";
        }

        #region "Initialisation des composants"
        private void setUpComposants()
        {
           
            if(this.trader.responsable == 1)
            {
                this.btnPromoteResponsable.Enabled = false;
                this.btnPromoteResponsable.BackColor = Color.Gray;
            }
            else
            {
                this.btnRevoquerUser.Enabled = false;
                this.btnRevoquerUser.BackColor = Color.Gray;
            }
            
            if (this.trader.suspendu == 0)
            {
                this.btnRehabilitation.Enabled = false;
                this.btnRehabilitation.BackColor = Color.Gray;
            }
            else
            {
                this.btnSuspension.Enabled = false;
                this.btnSuspension.BackColor = Color.Gray;
            }
            this.lblUserTitre.Text = "Gestion de l'utilisateur (" + this.trader.id.ToString() + ") : " + this.trader.first_name + " " + this.trader.last_name;

            this.txbFirstName.Text = this.trader.first_name;
            this.txbLastName.Text = this.trader.last_name;
            this.txbEmail.Text = this.trader.email;

            dtgMouvements.ColumnCount = 5;

            dtgMouvements.Columns[0].Name = "Type";
            dtgMouvements.Columns[1].Name = "Code ISIN";
            dtgMouvements.Columns[2].Name = "Quantité";
            dtgMouvements.Columns[3].Name = "Date";
            dtgMouvements.Columns[4].Name = "Montant";

            remplirDataGridView();

        }

        private void remplirDataGridView()
        {
            var listeMouvements = JsonConvert.DeserializeObject<List<Mouvement>>(this.mouvements);
            if(listeMouvements != null)
            {
                listeMouvements.Reverse();
                foreach(Mouvement mouvement in listeMouvements)
                {
                    dtgMouvements.Rows.Add(
                        mouvement.type_mouvement.ToString(),
                        mouvement.isin_code.ToString(),
                        mouvement.quantite.ToString(),
                        mouvement.date_mouvement.ToString(),
                        mouvement.montant.ToString()
                        );
                }

                for(int i = 0; i < dtgMouvements.Rows.Count - 1; i++)
                {
                    if(dtgMouvements.Rows[i].Cells[0].Value.ToString() == "SELL")
                    {
                        dtgMouvements.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        dtgMouvements.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    }
                }
            }
        }
        #endregion

        #region "Action des boutons"

        private async void btnPromoteResponsable_Click(object sender, EventArgs e)
        {

            string route = APIManager.API_ROUTES_ADD_ROLE;
            var donnees = new { userId = this.trader.id, roleToAdd = "responsable" };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                this.btnPromoteResponsable.Enabled = false;
                this.btnPromoteResponsable.BackColor = Color.Gray;

                this.btnRevoquerUser.Enabled = true;
                this.btnRevoquerUser.BackColor = Color.DarkRed;
            }

            MessageBox.Show(reponse.SelectToken("message").ToString());

        }

        private async void btnRevoquerUser_Click(object sender, EventArgs e)
        {

            string route = APIManager.API_ROUTES_REMOVE_ROLE;
            var donnees = new { userId = this.trader.id, roleToRemove = "responsable" };

            JToken reponse = await APIManager.posterData(route, donnees);


            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                this.btnRevoquerUser.Enabled = false;
                this.btnRevoquerUser.BackColor = Color.Gray;

                this.btnPromoteResponsable.Enabled = true;
                this.btnPromoteResponsable.BackColor = Color.LimeGreen;
            }

            MessageBox.Show(reponse.SelectToken("message").ToString());
        }

        private async void btnRehabilitation_Click(object sender, EventArgs e)
        {

            string route = APIManager.API_ROUTES_REMOVE_ROLE;
            var donnees = new { userId = this.trader.id, roleToRemove = "suspendu" };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                this.btnRehabilitation.Enabled = false;
                this.btnRehabilitation.BackColor = Color.Gray;

                this.btnSuspension.Enabled = true;
                this.btnSuspension.BackColor = Color.DarkRed;
            }

            MessageBox.Show(reponse.SelectToken("message").ToString());
        }

        private async void btnSuspension_Click(object sender, EventArgs e)
        {

            string route = APIManager.API_ROUTES_ADD_ROLE;
            var donnees = new { userId = this.trader.id, roleToAdd = "suspendu" };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                this.btnSuspension.Enabled = false;
                this.btnSuspension.BackColor = Color.Gray;

                this.btnRehabilitation.Enabled = true;
                this.btnRehabilitation.BackColor = Color.Orange;
            }

            MessageBox.Show(reponse.SelectToken("message").ToString());

        }

        private async void btnAccorderBudget_Click(object sender, EventArgs e)
        {

            decimal montantAjout = this.txbMontantAjout.Value;

            string route = APIManager.API_ROUTES_POST_ADDBUDGET;
            var donnees = new { userId = this.trader.id, budgetToAdd = montantAjout };

            JToken reponse = await APIManager.posterData(route, donnees);

            MessageBox.Show(reponse.SelectToken("message").ToString());

        }

        private async void btnEditInformations_Click(object sender, EventArgs e)
        {
            string firstName = this.txbFirstName.Text;
            string lastName = this.txbLastName.Text;
            string email = this.txbEmail.Text;

            string route = APIManager.API_ROUTES_POST_EDITUSER;
            var donnees = new
            {
                userId = this.trader.id,
                firstName = firstName,
                lastName = lastName,
                email = email
            };

            JToken reponse = await APIManager.posterData(route, donnees);
            MessageBox.Show(reponse.SelectToken("message").ToString());
        }

        #endregion


    }
}
