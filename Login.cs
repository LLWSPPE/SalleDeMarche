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
using BCrypt.Net;

namespace LLWS
{
    public partial class Login : Form
    {

        private DatabaseManager databaseManager = new DatabaseManager();
        private MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(txbMail.Text) || String.IsNullOrEmpty(txbPassword.Text)){
                //Si un des champs est vide: erreur.
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                this.databaseManager.openNewConnection();
                this.connection = this.databaseManager.GetMySqlConnection();

                //On cherche un utilisateur dans la table user qui possède l'email renseigné.
                MySqlCommand command = new MySqlCommand("select * from user where email=@Mail", this.connection);
                command.Parameters.AddWithValue("@Mail", txbMail.Text);

                MySqlDataReader lecteur;
                lecteur = command.ExecuteReader();

                if (lecteur.HasRows)
                    //Si une occurence est trouvée.
                {
                    while (lecteur.Read())
                    {
                        //On récupère le mot de passe.
                        string passwordFromDb = lecteur.GetString(2);
                        if (!BCrypt.Net.BCrypt.Verify(txbPassword.Text, passwordFromDb))
                        {
                            //Cette fonction renvoie True si le mot de passe encodé est le meme que le mot de passe dans la Db.
                            //Ici, si la fonction renvoie False, alors les mots de passes ne sont pas identiques.
                            MessageBox.Show("Mot de passe incorrect, veuillez réessayer.");
                        }
                        else
                        {
                            //Si tout est correct, on ouvre la fenêtre principale.
                            MainMenu mainWindows = new MainMenu();
                            mainWindows.Show();
                            this.Hide();
                        }
                    }
                   
                }
                else
                {
                    //Si aucune ligne n'est trouvé dans la db, alors l'utilisateur avec cet email n'existe pas.
                    MessageBox.Show("Les identifiants de connexion sont incorrects, veuillez réessayer.");
                }

                lecteur.Close();
                this.connection.Close();

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
