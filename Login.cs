using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Core;
using MySql.Data.MySqlClient;
using LLWS.UserInterface;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using LLWS.Models;
using System.Net.Http;

namespace LLWS
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            this.txbPassword.PasswordChar = '•';

        }

        #region "Actions des boutons"

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txbMail.Text;
            string password = this.txbPassword.Text;

            var task = GetApiData(email, password);
            var items = await task;

            if(task.GetAwaiter().GetResult().ToString() != "")
            {
                this.Hide();
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            txbPassword.Text = "";
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "") txbPassword.Text = "mot de passe";
        }

        private void txbMail_Leave(object sender, EventArgs e)
        {
            if (txbMail.Text == "") txbMail.Text = "adresse mail";
        }

        private void txbMail_Enter(object sender, EventArgs e)
        {
            txbMail.Text = "";
        }

        #endregion

        #region "Tâches asynchrones"

        /*
         * Cette fonction est asynchrone et fonctionne de manière non bloquante.
         * On poste les informations sur notre la route précisée de notre API.
         * La réponse renvoyée est un tableau JSON converti en STRING
         * On récupère l'état de la réponse
         * Le token de connexion récupéré sera stocké dans la classe statique "Models/User" et servira tout au long du cycle de vie de l'application
         */

        private static async Task<string> GetApiData(string email, string password)
        {

            string userToken = "";

            //Les informations sont postéee
            var responseString = await APIManager.API_ROUTE_LOGIN
            .PostUrlEncodedAsync(new { email = email, password = password })
            .ReceiveString();

            //On naviague à travers la réponse Json
            JToken token = JToken.Parse(responseString);

            if (token.SelectToken("status").ToString() == "ERROR")
            {
                MessageBox.Show(token.SelectToken("message").ToString());
            }

            if (token.SelectToken("status").ToString() == "SUCCESS")
            {
                //Si les infos sont correctes
                userToken = (string)token.SelectToken("result[0].loginToken");
                //Le token et les informations de la session sont stockées dans la classe statique.

                
                User.id = (int)token.SelectToken("result[0].id");
                User.first_name = (string)token.SelectToken("result[0].first_name");
                User.last_name = (string)token.SelectToken("result[0].last_name");
                User.userToken = userToken;
                User.budget = (double)token.SelectToken("result[0].budget");
                User.admin = (int)token.SelectToken("result[0].admin");

                //On affiche la fenêtre principale.
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();


            }

            return userToken;

        }
        #endregion
    }
}
