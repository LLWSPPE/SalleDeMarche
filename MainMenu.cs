﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Core;
using LLWS.UserInterface.Products;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using LLWS.Models;

namespace LLWS
{
    public partial class MainMenu : Form
    {

        //Properties
        private Button activeBtn; // Bouton actif
        private Form activeForm; // Fenêtre active

        public MainMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.lblUserBudget.Text = User.budget.ToString() + "€";

            //On cache les boutons si l'utilisateur de la session n'est pas un admin / responsable
            if (User.admin == 0)
            {
                this.btnManageUser.Visible = false;
                this.btnManageCotations.Visible = false;
            }

        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            btnProducts.PerformClick();
        }


        #region "Action des boutons"

        // Liste des actions associées aux boutons
        //Les boutons avec une fonction "async" ont pour effet d'appeller de manière asynchrone une fonction qui chargera une réponse de l'API.
        //Tant qu'aucune réponse n'a été reçue, le composant de la Form correspondant ne chargera pas.
        private void btnProducts_Click(object sender, EventArgs e)
        {

            OpenActiveForm(new Products(), sender);

        }

        private async void btnOperations_Click(object sender, EventArgs e)
        {

            string reponsePortefeuille = "";
            string routePortefeuille = APIManager.API_ROUTES_GET_USER_PORTEFEUILLE + User.id.ToString();

            JToken reponse = await APIManager.recevoirData(routePortefeuille);

            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                reponsePortefeuille = reponse.SelectToken("result").ToString();
                OpenActiveForm(new UserInterface.Operations.Operations(reponsePortefeuille), sender);
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.");
            }

        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            OpenActiveForm(new UserInterface.RegisterForm(), sender);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        //BOUTONS POUR ADMIN 

        private async void btnManageUser_Click(object sender, EventArgs e)
        {
            string route = APIManager.API_ROUTES_GET_USERS;

            JToken reponse = await APIManager.recevoirData(route);
            OpenActiveForm(new UserInterface.Responsable.ManageUsers(reponse.SelectToken("result").ToString()), sender);
        }


        #endregion

        #region "Fonctions associées aux boutons"
        private void ActivateButton(object sender)
        {
            //Active un bouton lorsqu'il est cliqué, change sa couleur et la police.
            if (sender != null)
            {
                if (activeBtn != (Button)sender)
                {
                    DesactivateOtherButton();
                    activeBtn = (Button)sender;
                    activeBtn.BackColor = Color.FromArgb(46, 134, 122);
                    activeBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void DesactivateOtherButton()
        {
            //Lorsqu'un bouton est cliqué, cette fonction est appellée et désactive les autres boutons (remet la couleur et l'ancienne police)
            foreach (Control resetBtn in pnlSidebar.Controls)
            {
                resetBtn.BackColor = Color.FromArgb(39, 60, 117);
                resetBtn.ForeColor = Color.White;
            }
        }

        private void OpenActiveForm(Form childForm, object sender)
        {
            /*
             * Lorsqu'un bouton est cliqué, la fenêtre principale change en fonction du Form qui lui est associé
             * Exemple : btnLogin -> LoginForm
             * On change le titre du label en haut (labelWindowTitle)
             * le panelMainWindow se transforme en le Form qui lui correspond
             */
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelMainWindow.Controls.Add(childForm);
            this.panelMainWindow.Tag = childForm;

            this.labelWindowTitle.Text = childForm.Text;

            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

    }
}
