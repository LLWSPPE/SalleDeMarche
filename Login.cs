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
using Newtonsoft.Json;

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
            string route = APIManager.API_ROUTE_LOGIN;

            var donnees = new {
                email = email,
                password = password
            };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("status").ToString() == "ERROR") {
                MessageBox.Show(reponse.SelectToken("message").ToString());
            }
            else
            {

                User.id = (int)reponse.SelectToken("result[0].id");
                User.first_name = (string)reponse.SelectToken("result[0].first_name");
                User.last_name = (string)reponse.SelectToken("result[0].last_name");
                User.userToken = (string)reponse.SelectToken("result[0].loginToken"); ;
                User.budget = (double)reponse.SelectToken("result[0].budget");
                User.admin = (int)reponse.SelectToken("result[0].admin");
                User.responsable = (int)reponse.SelectToken("result[0].responsable");

                JToken reponseCotations = await APIManager.recevoirData(APIManager.API_ROUTES_GET_ALL_COTATIONS);

                if(reponseCotations.SelectToken("status").ToString() == "ERROR")
                {
                    MessageBox.Show("Il y a eu une erreur pour récupérer les cotations du jour.");
                }

                else
                {
                    var cotationsDeserialisees = JsonConvert.DeserializeObject<List<Cotation>>(reponseCotations.SelectToken("result").ToString());
                    this.Hide();
                    CotationsDuJour.ListeCotation = cotationsDeserialisees;
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }


            }
  
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            txbPassword.Text = "";
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "") txbPassword.Text = "Mot de passe";
        }

        private void txbMail_Leave(object sender, EventArgs e)
        {
            if (txbMail.Text == "") txbMail.Text = "Adresse mail";
        }

        private void txbMail_Enter(object sender, EventArgs e)
        {
            txbMail.Text = "";
        }

        #endregion

    }
}
