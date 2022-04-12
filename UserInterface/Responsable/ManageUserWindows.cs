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

        public ManageUserWindows(Trader trader)
        {
            InitializeComponent();
            this.trader = trader;
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
        }
        #endregion

        #region "Action des boutons"

        private async void btnPromoteResponsable_Click(object sender, EventArgs e)
        {

            string route = APIManager.API_ROUTES_POST_PROMOTE;
            var donnees = new { userId = this.trader.id };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("message").ToString() == "Cet utilisateur a été promu responsable")
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

            string route = APIManager.API_ROUTES_POST_REVOKE;
            var donnees = new { userId = this.trader.id };

            JToken reponse = await APIManager.posterData(route, donnees);


            if (reponse.SelectToken("message").ToString() == "Cet utilisateur a vu ses droits de responsable révoqués.")
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

            string route = APIManager.API_ROUTES_POST_REHABILITATE;
            var donnees = new { userId = this.trader.id };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("message").ToString() == "Cet utilisateur a été réhabilité et peut recommencer à trader.")
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

            string route = APIManager.API_ROUTES_POST_SUSPENSION;
            var donnees = new { userId = this.trader.id };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("message").ToString() == "Cet utilisateur a été suspendu. Il ne peut plus faire d'action sur le marché.")
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
