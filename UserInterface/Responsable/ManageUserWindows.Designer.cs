
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
            this.btnAccorderBudget = new System.Windows.Forms.Button();
            this.btnSuspension = new System.Windows.Forms.Button();
            this.btnPromoteResponsable = new System.Windows.Forms.Button();
            this.lblUserTitre = new System.Windows.Forms.Label();
            this.lblAjoutMontant = new System.Windows.Forms.Label();
            this.btnRevoquerUser = new System.Windows.Forms.Button();
            this.btnRehabilitation = new System.Windows.Forms.Button();
            this.txbMontantAjout = new System.Windows.Forms.NumericUpDown();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEditInformations = new System.Windows.Forms.Button();
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
            this.pnlActions.Location = new System.Drawing.Point(12, 12);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(200, 395);
            this.pnlActions.TabIndex = 0;
            // 
            // btnAccorderBudget
            // 
            this.btnAccorderBudget.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccorderBudget.Location = new System.Drawing.Point(21, 330);
            this.btnAccorderBudget.Name = "btnAccorderBudget";
            this.btnAccorderBudget.Size = new System.Drawing.Size(163, 52);
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
            this.btnSuspension.Location = new System.Drawing.Point(21, 209);
            this.btnSuspension.Name = "btnSuspension";
            this.btnSuspension.Size = new System.Drawing.Size(163, 53);
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
            this.btnPromoteResponsable.Location = new System.Drawing.Point(21, 30);
            this.btnPromoteResponsable.Name = "btnPromoteResponsable";
            this.btnPromoteResponsable.Size = new System.Drawing.Size(163, 49);
            this.btnPromoteResponsable.TabIndex = 0;
            this.btnPromoteResponsable.Text = "Promouvoir Responsable ";
            this.btnPromoteResponsable.UseVisualStyleBackColor = false;
            this.btnPromoteResponsable.Click += new System.EventHandler(this.btnPromoteResponsable_Click);
            // 
            // lblUserTitre
            // 
            this.lblUserTitre.AutoSize = true;
            this.lblUserTitre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitre.Location = new System.Drawing.Point(237, 21);
            this.lblUserTitre.Name = "lblUserTitre";
            this.lblUserTitre.Size = new System.Drawing.Size(140, 29);
            this.lblUserTitre.TabIndex = 1;
            this.lblUserTitre.Text = "Titre gestion";
            // 
            // lblAjoutMontant
            // 
            this.lblAjoutMontant.AutoSize = true;
            this.lblAjoutMontant.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutMontant.Location = new System.Drawing.Point(17, 275);
            this.lblAjoutMontant.Name = "lblAjoutMontant";
            this.lblAjoutMontant.Size = new System.Drawing.Size(184, 24);
            this.lblAjoutMontant.TabIndex = 4;
            this.lblAjoutMontant.Text = "Ajouter un montant :";
            // 
            // btnRevoquerUser
            // 
            this.btnRevoquerUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnRevoquerUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoquerUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRevoquerUser.Location = new System.Drawing.Point(21, 85);
            this.btnRevoquerUser.Name = "btnRevoquerUser";
            this.btnRevoquerUser.Size = new System.Drawing.Size(163, 59);
            this.btnRevoquerUser.TabIndex = 5;
            this.btnRevoquerUser.Text = "Révoquer les droits";
            this.btnRevoquerUser.UseVisualStyleBackColor = false;
            this.btnRevoquerUser.Click += new System.EventHandler(this.btnRevoquerUser_Click);
            // 
            // btnRehabilitation
            // 
            this.btnRehabilitation.BackColor = System.Drawing.Color.Orange;
            this.btnRehabilitation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRehabilitation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRehabilitation.Location = new System.Drawing.Point(21, 150);
            this.btnRehabilitation.Name = "btnRehabilitation";
            this.btnRehabilitation.Size = new System.Drawing.Size(163, 53);
            this.btnRehabilitation.TabIndex = 6;
            this.btnRehabilitation.Text = "Réhabiliter";
            this.btnRehabilitation.UseVisualStyleBackColor = false;
            this.btnRehabilitation.Click += new System.EventHandler(this.btnRehabilitation_Click);
            // 
            // txbMontantAjout
            // 
            this.txbMontantAjout.Location = new System.Drawing.Point(21, 303);
            this.txbMontantAjout.Name = "txbMontantAjout";
            this.txbMontantAjout.Size = new System.Drawing.Size(163, 22);
            this.txbMontantAjout.TabIndex = 7;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(241, 85);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(198, 22);
            this.txbFirstName.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(514, 85);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(201, 22);
            this.txbLastName.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(241, 147);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(474, 22);
            this.txbEmail.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(237, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 19);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "Prénom";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(512, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(39, 19);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Nom";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(237, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Adresse mail";
            // 
            // lblEditInformations
            // 
            this.lblEditInformations.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInformations.Location = new System.Drawing.Point(241, 192);
            this.lblEditInformations.Name = "lblEditInformations";
            this.lblEditInformations.Size = new System.Drawing.Size(474, 42);
            this.lblEditInformations.TabIndex = 8;
            this.lblEditInformations.Text = "Modifier les informations";
            this.lblEditInformations.UseVisualStyleBackColor = true;
            this.lblEditInformations.Click += new System.EventHandler(this.lblEditInformations_Click);
            // 
            // ManageUserWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 419);
            this.Controls.Add(this.lblEditInformations);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lblUserTitre);
            this.Controls.Add(this.pnlActions);
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
        private System.Windows.Forms.Button lblEditInformations;
    }
}