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
using Flurl.Http;
using Newtonsoft.Json.Linq;
using LLWS.Core;

namespace LLWS.UserInterface
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }


        #region "Actions des composants"
        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbFirstName_Enter(object sender, EventArgs e)
        {
            txbFirstName.Text = "";
        }

        private void txbFirstName_Leave(object sender, EventArgs e)
        {
            if (txbFirstName.Text =="") txbFirstName.Text = " Nom ";
        }

        private void txbLastName_Enter(object sender, EventArgs e)
        {
            txbLastName.Text = "";
        }

        private void txbLastName_Leave(object sender, EventArgs e)
        {
            if (txbLastName.Text == "") txbLastName.Text = " Prénom ";
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            txbEmail.Text = "";
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "") txbEmail.Text = " Email ";
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            txbPassword.Text = "";
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "") txbPassword.Text = "Mot de passe";
        }

        private void txbConfirmPassword_Enter(object sender, EventArgs e)
        {
            txbConfirmPassword.Text = "";
        }

        private void txbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == "") txbConfirmPassword.Text = "Confirmez le mot de passe";
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {

            string firstName = this.txbFirstName.Text;
            string lastName = this.txbLastName.Text;
            string email = this.txbEmail.Text;
            string password = this.txbPassword.Text;
            string confirmPassword = this.txbPassword.Text;

            string route = APIManager.API_ROUTE_REGISTER;

            var donnees = new
            {
                firstName = firstName,
                lastName = lastName,
                email = email,
                password = password,
                confirmPassword = confirmPassword
            };

            JToken reponse = await APIManager.posterData(route, donnees);

            if (reponse.SelectToken("status").ToString() == "ERROR")
            {
                MessageBox.Show(reponse.SelectToken("message").ToString());
            }
            else
            {
               
                MessageBox.Show("Utilisateur enregistré. Vous pouvez désormais vous connecter avec vos nouveaux identifiants");
                this.Hide();

                Login loginForm = new Login();
                loginForm.Show();

            }

        }
        #endregion

    }
}
