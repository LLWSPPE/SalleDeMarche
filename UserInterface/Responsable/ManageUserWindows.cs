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
            var task = await PromoteUser(this.trader.id);
            if (task == "Cet utilisateur a été promu responsable")
            {
                this.btnPromoteResponsable.Enabled = false;
                this.btnPromoteResponsable.BackColor = Color.Gray;

                this.btnRevoquerUser.Enabled = true;
                this.btnRevoquerUser.BackColor = Color.DarkRed;
            }

            MessageBox.Show(task);

        }

        private async void btnRevoquerUser_Click(object sender, EventArgs e)
        {
            var task = await RevokeUser(this.trader.id);

            if (task == "Cet utilisateur a vu ses droits de responsable révoqués.")
            {
                this.btnRevoquerUser.Enabled = false;
                this.btnRevoquerUser.BackColor = Color.Gray;

                this.btnPromoteResponsable.Enabled = true;
                this.btnPromoteResponsable.BackColor = Color.LimeGreen;
            }

            MessageBox.Show(task);
        }

        private async void btnRehabilitation_Click(object sender, EventArgs e)
        {
            var task = await RehabiliteUser(this.trader.id);

            if (task == "Cet utilisateur a été réhabilité et peut recommencer à trader.")
            {
                this.btnRehabilitation.Enabled = false;
                this.btnRehabilitation.BackColor = Color.Gray;

                this.btnSuspension.Enabled = true;
                this.btnSuspension.BackColor = Color.DarkRed;
            }

            MessageBox.Show(task);
        }

        private async void btnSuspension_Click(object sender, EventArgs e)
        {

            var task = await SuspendreUser(this.trader.id);

            if (task == "Cet utilisateur a été suspendu. Il ne peut plus faire d'action sur le marché.")
            {
                this.btnSuspension.Enabled = false;
                this.btnSuspension.BackColor = Color.Gray;

                this.btnRehabilitation.Enabled = true;
                this.btnRehabilitation.BackColor = Color.Orange;
            }

            MessageBox.Show(task);

        }

        private async void btnAccorderBudget_Click(object sender, EventArgs e)
        {
            decimal montantAjout = this.txbMontantAjout.Value;
            var task = await AddBudget(this.trader.id, montantAjout);

            MessageBox.Show(task);

        }

        private async void btnEditInformations_Click(object sender, EventArgs e)
        {
            string firstName = this.txbFirstName.Text;
            string lastName = this.txbLastName.Text;
            string email = this.txbEmail.Text;

            var task = await EditUser(this.trader.id, firstName, lastName, email);
            MessageBox.Show(task);
        }

        #endregion

        #region "Tâches asyncrhones"

        private static async Task<string> PromoteUser(int userId)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_PROMOTE
            .PostUrlEncodedAsync(new { userId = userId })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }

        private static async Task<string> SuspendreUser(int userId)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_SUSPENSION
            .PostUrlEncodedAsync(new { userId = userId })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }

        private static async Task<string> RehabiliteUser(int userId)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_REHABILITATE
            .PostUrlEncodedAsync(new { userId = userId })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }


        private static async Task<string> RevokeUser(int userId)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_REVOKE
            .PostUrlEncodedAsync(new { userId = userId })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }

        private static async Task<string> AddBudget(int userId, decimal montant)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_ADDBUDGET
            .PostUrlEncodedAsync(new { userId = userId, budgetToAdd = montant })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);
            response = token.SelectToken("message").ToString();
            return response;

        }

        private static async Task<string> EditUser(int userId, string firstName, string lastName, string email)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_EDITUSER
            .PostUrlEncodedAsync(new { 
                userId = userId, 
                firstName = firstName,
                lastName = lastName,
                email = email
            })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);
            response = token.SelectToken("message").ToString();
            return response;

        }
        #endregion

    }
}
