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

namespace LLWS.UserInterface
{
    public partial class RegisterForm : Form
    {

        List<string> errors = new List<string>();
        

        public RegisterForm()
        {
            InitializeComponent();
            lblError.Hide();
        }


        private static async Task sendRegisterFormToAPI(string firstName, string lastName, string email, string password, string confirmPassword)
        {

            var responseString = await APIManager.API_ROUTE_REGISTER
            .PostUrlEncodedAsync(new { firstName = firstName, lastName = lastName, email = email, password = password, confirmPassword = confirmPassword })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            if (token.SelectToken("status").ToString() == "ERROR")
            {
                MessageBox.Show(token.SelectToken("message").ToString());
            }

            if (token.SelectToken("status").ToString() == "SUCCESS")
            {
                MessageBox.Show("Utilisateur enregistré. Vous pouvez désormais vous connecter avec vos nouveaux identifiants");


            }

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            //Chaque fois qu'on clique le bouton, on remet les erreurs à 0, sinon elles s'accumulent.
            if(this.errors.Count > 0)
            {
                this.errors.Clear();
            }

            string firstName = this.txbFirstName.Text;
            string lastName = this.txbLastName.Text;
            string email = this.txbEmail.Text;
            string password = this.txbPassword.Text;
            string confirmPassword = this.txbPassword.Text;

            var task = sendRegisterFormToAPI(firstName, lastName, email, password, confirmPassword);
            await task;


            if (this.errors.Count > 0)
            {
                //Si le tableau d'erreur n'est pas vide, on affiche un label rouge contenant le premier message d'erreur (ordre de verification)
                this.lblError.Show();
                this.lblError.Text = this.errors[0];
                this.lblError.ForeColor = Color.Red;
            }



        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
