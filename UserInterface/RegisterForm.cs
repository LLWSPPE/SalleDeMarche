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
using BCrypt.Net;

namespace LLWS.UserInterface
{
    public partial class RegisterForm : Form
    {

        List<string> errors = new List<string>();
        DatabaseManager databaseManager = new DatabaseManager();
        MySqlConnection connection;
        

        public RegisterForm()
        {
            InitializeComponent();
            lblError.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Chaque fois qu'on clique le bouton, on remet les erreurs à 0, sinon elles s'accumulent.
            if(this.errors.Count > 0)
            {
                this.errors.Clear();
            }
            
            //Vérification : si un des champs est vide.
            if( String.IsNullOrEmpty(txbFirstName.Text) ||
                String.IsNullOrEmpty(txbLastName.Text)  ||
                String.IsNullOrEmpty(txbEmail.Text)     ||
                String.IsNullOrEmpty(txbPassword.Text)  ||
                String.IsNullOrEmpty(txbConfirmPassword.Text))
            {
                this.errors.Add("Veuillez remplir tous les champs !");
            }

            //Vérification: si le nom est prénom est trop court.
            else if(txbFirstName.Text.Length < 3 || txbLastName.Text.Length < 3)
            {
                this.errors.Add("Votre nom et prénom doivent faire plus de 3 caractères.");
            }

            else if (txbPassword.Text.Length < 8)
            {
                //On pourrait ajouter des vérifications si le mdp contient des majuscules/chiffres/symboles pour + de sécurité.
                this.errors.Add("Votre mot de passe doit faire au moins 8 caractères.");
            }

            //Vérification: si les deux mots de passes ne correspondent pas.
            else if(!String.Equals(txbPassword.Text, txbConfirmPassword.Text))
            {
                this.errors.Add("Les mots de passe renseignés ne sont pas identiques.");
            }

            else
            {
                this.databaseManager.openNewConnection();
                this.connection = this.databaseManager.GetMySqlConnection();

                //On cherche un utilisateur dans la Db pour savoir si l'email existe déjà.
                MySqlCommand command = new MySqlCommand("select * from user where email=@Mail", this.connection);
                command.Parameters.AddWithValue("@Mail", txbEmail.Text);

                Console.WriteLine(command.ToString());
                MySqlDataReader lecteur;

                lecteur = command.ExecuteReader();

                if (lecteur.HasRows)
                {
                    //Si une occurence est trouvée, alors l'email est déjà utilisée.
                    this.errors.Add("Cette adresse mail est déjà utilisée.");
                    this.connection.Close();
                }

                lecteur.Close();

                //Si le tableau d'erreur est vide, alors aucune erreur.
                if(this.errors.Count == 0)
                {
                    //On encrypte le mot de passe.
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txbPassword.Text);

                    MySqlCommand newCommand = new MySqlCommand("INSERT INTO user values (@Id, @Email, @Password, @FirstName, @LastName, @RegisterDate, @Responsable, @Admin, @Suspendu, @DateDebut, @DateFin)", this.connection);
                    newCommand.Parameters.AddWithValue("@Id", null);
                    newCommand.Parameters.AddWithValue("@Email", txbEmail.Text);
                    newCommand.Parameters.AddWithValue("@Password", hashedPassword); // On ajoute le mot de passe encrypté.
                    newCommand.Parameters.AddWithValue("@FirstName", txbFirstName.Text);
                    newCommand.Parameters.AddWithValue("@LastName", txbLastName.Text);
                    newCommand.Parameters.AddWithValue("@RegisterDate", DateTime.Now);
                    newCommand.Parameters.AddWithValue("@Responsable", 0);
                    newCommand.Parameters.AddWithValue("@Admin", 0);
                    newCommand.Parameters.AddWithValue("@Suspendu", 0);
                    newCommand.Parameters.AddWithValue("@DateDebut", null);
                    newCommand.Parameters.AddWithValue("@DateFin", null);

                    newCommand.ExecuteNonQuery();
                    MessageBox.Show("Votre compte a bien été créé");
                }

            }

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
    }
}
