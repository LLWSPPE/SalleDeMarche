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
           
        }

        private static async Task<string> GetApiData(string email, string password)
        {

            string userToken = "";

            var responseString = await APIManager.API_ROUTE_LOGIN
            .PostUrlEncodedAsync(new { email = email, password = password })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            if (token.SelectToken("status").ToString() == "ERROR")
            {
                MessageBox.Show(token.SelectToken("message").ToString());
            }

            if (token.SelectToken("status").ToString() == "SUCCESS")
            {
                userToken = (string)token.SelectToken("result[0].loginToken");
                User.userToken = userToken;
                

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                

            }

            return userToken;

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txbMail.Text;
            string password = this.txbPassword.Text;

            var task = GetApiData(email, password);
            var items = await task;


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
    }
}
