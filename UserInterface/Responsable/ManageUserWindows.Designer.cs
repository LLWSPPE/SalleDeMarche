
namespace LLWS.UserInterface.Responsable
{
    partial class ManageUserWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlActions = new System.Windows.Forms.Panel();
            this.txbMontantAjout = new System.Windows.Forms.NumericUpDown();
            this.btnRehabilitation = new System.Windows.Forms.Button();
            this.btnRevoquerUser = new System.Windows.Forms.Button();
            this.lblAjoutMontant = new System.Windows.Forms.Label();
            this.btnAccorderBudget = new System.Windows.Forms.Button();
            this.btnSuspension = new System.Windows.Forms.Button();
            this.btnPromoteResponsable = new System.Windows.Forms.Button();
            this.lblUserTitre = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEditInformations = new System.Windows.Forms.Button();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbMontantAjout)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.txbMontantAjout);
            this.pnlActions.Controls.Add(this.btnRehabilitation);
            this.pnlActions.Controls.Add(this.btnRevoquerUser);
            this.pnlActions.Controls.Add(this.lblAjoutMontant);
            this.pnlActions.Controls.Add(this.btnAccorderBudget);
            this.pnlActions.Controls.Add(this.btnSuspension);
            this.pnlActions.Controls.Add(this.btnPromoteResponsable);
            this.pnlActions.Location = new System.Drawing.Point(9, 10);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(150, 321);
            this.pnlActions.TabIndex = 0;
            // 
            // txbMontantAjout
            // 
            this.txbMontantAjout.Location = new System.Drawing.Point(16, 246);
            this.txbMontantAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMontantAjout.Name = "txbMontantAjout";
            this.txbMontantAjout.Size = new System.Drawing.Size(122, 20);
            this.txbMontantAjout.TabIndex = 7;
            // 
            // btnRehabilitation
            // 
            this.btnRehabilitation.BackColor = System.Drawing.Color.Orange;
            this.btnRehabilitation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRehabilitation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRehabilitation.Location = new System.Drawing.Point(16, 122);
            this.btnRehabilitation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRehabilitation.Name = "btnRehabilitation";
            this.btnRehabilitation.Size = new System.Drawing.Size(122, 43);
            this.btnRehabilitation.TabIndex = 6;
            this.btnRehabilitation.Text = "Réhabiliter";
            this.btnRehabilitation.UseVisualStyleBackColor = false;
            this.btnRehabilitation.Click += new System.EventHandler(this.btnRehabilitation_Click);
            // 
            // btnRevoquerUser
            // 
            this.btnRevoquerUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnRevoquerUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoquerUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRevoquerUser.Location = new System.Drawing.Point(16, 69);
            this.btnRevoquerUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevoquerUser.Name = "btnRevoquerUser";
            this.btnRevoquerUser.Size = new System.Drawing.Size(122, 48);
            this.btnRevoquerUser.TabIndex = 5;
            this.btnRevoquerUser.Text = "Révoquer les droits";
            this.btnRevoquerUser.UseVisualStyleBackColor = false;
            this.btnRevoquerUser.Click += new System.EventHandler(this.btnRevoquerUser_Click);
            // 
            // lblAjoutMontant
            // 
            this.lblAjoutMontant.AutoSize = true;
            this.lblAjoutMontant.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutMontant.Location = new System.Drawing.Point(13, 223);
            this.lblAjoutMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAjoutMontant.Name = "lblAjoutMontant";
            this.lblAjoutMontant.Size = new System.Drawing.Size(117, 13);
            this.lblAjoutMontant.TabIndex = 4;
            this.lblAjoutMontant.Text = "Ajouter un montant :";
            // 
            // btnAccorderBudget
            // 
            this.btnAccorderBudget.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccorderBudget.Location = new System.Drawing.Point(16, 268);
            this.btnAccorderBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccorderBudget.Name = "btnAccorderBudget";
            this.btnAccorderBudget.Size = new System.Drawing.Size(122, 42);
            this.btnAccorderBudget.TabIndex = 2;
            this.btnAccorderBudget.Text = "Ajouter du budget";
            this.btnAccorderBudget.UseVisualStyleBackColor = true;
            this.btnAccorderBudget.Click += new System.EventHandler(this.btnAccorderBudget_Click);
            // 
            // btnSuspension
            // 
            this.btnSuspension.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuspension.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspension.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuspension.Location = new System.Drawing.Point(16, 170);
            this.btnSuspension.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuspension.Name = "btnSuspension";
            this.btnSuspension.Size = new System.Drawing.Size(122, 43);
            this.btnSuspension.TabIndex = 1;
            this.btnSuspension.Text = "Suspendre";
            this.btnSuspension.UseVisualStyleBackColor = false;
            this.btnSuspension.Click += new System.EventHandler(this.btnSuspension_Click);
            // 
            // btnPromoteResponsable
            // 
            this.btnPromoteResponsable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPromoteResponsable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromoteResponsable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPromoteResponsable.Location = new System.Drawing.Point(16, 24);
            this.btnPromoteResponsable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPromoteResponsable.Name = "btnPromoteResponsable";
            this.btnPromoteResponsable.Size = new System.Drawing.Size(122, 40);
            this.btnPromoteResponsable.TabIndex = 0;
            this.btnPromoteResponsable.Text = "Promouvoir Responsable ";
            this.btnPromoteResponsable.UseVisualStyleBackColor = false;
            this.btnPromoteResponsable.Click += new System.EventHandler(this.btnPromoteResponsable_Click);
            // 
            // lblUserTitre
            // 
            this.lblUserTitre.AutoSize = true;
            this.lblUserTitre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitre.Location = new System.Drawing.Point(178, 17);
            this.lblUserTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserTitre.Name = "lblUserTitre";
            this.lblUserTitre.Size = new System.Drawing.Size(93, 19);
            this.lblUserTitre.TabIndex = 1;
            this.lblUserTitre.Text = "Titre gestion";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(181, 69);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(150, 20);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(386, 69);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(152, 20);
            this.txbLastName.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(181, 119);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(356, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(178, 47);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 13);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "Prénom";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(384, 45);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(31, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Nom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(178, 98);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Adresse mail";
            // 
            // btnEditInformations
            // 
            this.btnEditInformations.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInformations.Location = new System.Drawing.Point(181, 156);
            this.btnEditInformations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditInformations.Name = "btnEditInformations";
            this.btnEditInformations.Size = new System.Drawing.Size(356, 34);
            this.btnEditInformations.TabIndex = 8;
            this.btnEditInformations.Text = "Modifier les informations";
            this.btnEditInformations.UseVisualStyleBackColor = true;
            this.btnEditInformations.Click += new System.EventHandler(this.btnEditInformations_Click);
            // 
            // ManageUserWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 340);
            this.Controls.Add(this.btnEditInformations);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lblUserTitre);
            this.Controls.Add(this.pnlActions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageUserWindows";
            this.Text = "ManageUserWindows";
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbMontantAjout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAccorderBudget;
        private System.Windows.Forms.Button btnSuspension;
        private System.Windows.Forms.Button btnPromoteResponsable;
        private System.Windows.Forms.Label lblUserTitre;
        private System.Windows.Forms.Label lblAjoutMontant;
        private System.Windows.Forms.Button btnRevoquerUser;
        private System.Windows.Forms.Button btnRehabilitation;
        private System.Windows.Forms.NumericUpDown txbMontantAjout;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEditInformations;
    }
}