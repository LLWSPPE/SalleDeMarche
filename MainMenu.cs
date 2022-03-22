using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        #region BtnFunction
        private void ActivateButton(object sender)
        {
            //Active un bouton lorsqu'il est cliqué, change sa couleur et la police.
            if(sender != null)
            {
                if(activeBtn != (Button)sender)
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
            foreach(Control resetBtn in pnlSidebar.Controls)
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
            if(activeForm != null)
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

        #region btnActions

        // Liste des actions associées aux boutons
        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenActiveForm(new UserInterface.LoginForm(), sender);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenActiveForm(new UserInterface.RegisterForm(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            OpenActiveForm(new UserInterface.RegisterForm(), sender);
        }

        #endregion

        private void panelWindowTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
