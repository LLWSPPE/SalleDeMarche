﻿
namespace LLWS.UserInterface.Operations
{
    partial class Operations
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
            this.dtgMonPortefeuille = new System.Windows.Forms.DataGridView();
            this.dtgCotations = new System.Windows.Forms.DataGridView();
            this.lblMonPortefeuille = new System.Windows.Forms.Label();
            this.lblCotationsDuJour = new System.Windows.Forms.Label();
            this.lblMyBudget = new System.Windows.Forms.Label();
            this.pnlVendre = new System.Windows.Forms.Panel();
            this.lblValeurActuelle = new System.Windows.Forms.Label();
            this.lblQuantiteVente = new System.Windows.Forms.Label();
            this.lblNombrePossede = new System.Windows.Forms.Label();
            this.btnVendreAction = new System.Windows.Forms.Button();
            this.lblSociete = new System.Windows.Forms.Label();
            this.lblVendreTitre = new System.Windows.Forms.Label();
            this.nupQuantite = new System.Windows.Forms.NumericUpDown();
            this.pnlAchat = new System.Windows.Forms.Panel();
            this.btnAchat = new System.Windows.Forms.Button();
            this.nupQuantiteAchat = new System.Windows.Forms.NumericUpDown();
            this.lblQuantiteAchat = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            this.lblSociete2 = new System.Windows.Forms.Label();
            this.lblAchatAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonPortefeuille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).BeginInit();
            this.pnlVendre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantite)).BeginInit();
            this.pnlAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantiteAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMonPortefeuille
            // 
            this.dtgMonPortefeuille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMonPortefeuille.ColumnHeadersHeight = 29;
            this.dtgMonPortefeuille.Location = new System.Drawing.Point(9, 80);
            this.dtgMonPortefeuille.Margin = new System.Windows.Forms.Padding(2);
            this.dtgMonPortefeuille.Name = "dtgMonPortefeuille";
            this.dtgMonPortefeuille.RowHeadersWidth = 51;
            this.dtgMonPortefeuille.RowTemplate.Height = 24;
            this.dtgMonPortefeuille.Size = new System.Drawing.Size(548, 402);
            this.dtgMonPortefeuille.TabIndex = 0;
            this.dtgMonPortefeuille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMonPortefeuille_CellClick);
            // 
            // dtgCotations
            // 
            this.dtgCotations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCotations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCotations.ColumnHeadersHeight = 29;
            this.dtgCotations.Location = new System.Drawing.Point(578, 80);
            this.dtgCotations.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCotations.Name = "dtgCotations";
            this.dtgCotations.RowHeadersWidth = 51;
            this.dtgCotations.RowTemplate.Height = 24;
            this.dtgCotations.Size = new System.Drawing.Size(1029, 402);
            this.dtgCotations.TabIndex = 1;
            this.dtgCotations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCotations_CellClick);
            // 
            // lblMonPortefeuille
            // 
            this.lblMonPortefeuille.AutoSize = true;
            this.lblMonPortefeuille.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonPortefeuille.Location = new System.Drawing.Point(9, 35);
            this.lblMonPortefeuille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonPortefeuille.Name = "lblMonPortefeuille";
            this.lblMonPortefeuille.Size = new System.Drawing.Size(173, 28);
            this.lblMonPortefeuille.TabIndex = 2;
            this.lblMonPortefeuille.Text = "Mon portefeuille";
            // 
            // lblCotationsDuJour
            // 
            this.lblCotationsDuJour.AutoSize = true;
            this.lblCotationsDuJour.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotationsDuJour.Location = new System.Drawing.Point(573, 35);
            this.lblCotationsDuJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCotationsDuJour.Name = "lblCotationsDuJour";
            this.lblCotationsDuJour.Size = new System.Drawing.Size(176, 28);
            this.lblCotationsDuJour.TabIndex = 3;
            this.lblCotationsDuJour.Text = "Cotations du jour";
            // 
            // lblMyBudget
            // 
            this.lblMyBudget.AutoSize = true;
            this.lblMyBudget.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBudget.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMyBudget.Location = new System.Drawing.Point(9, 7);
            this.lblMyBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyBudget.Name = "lblMyBudget";
            this.lblMyBudget.Size = new System.Drawing.Size(181, 28);
            this.lblMyBudget.TabIndex = 4;
            this.lblMyBudget.Text = "Mon budget : 100";
            // 
            // pnlVendre
            // 
            this.pnlVendre.Controls.Add(this.lblValeurActuelle);
            this.pnlVendre.Controls.Add(this.lblQuantiteVente);
            this.pnlVendre.Controls.Add(this.lblNombrePossede);
            this.pnlVendre.Controls.Add(this.btnVendreAction);
            this.pnlVendre.Controls.Add(this.lblSociete);
            this.pnlVendre.Controls.Add(this.lblVendreTitre);
            this.pnlVendre.Controls.Add(this.nupQuantite);
            this.pnlVendre.Location = new System.Drawing.Point(9, 501);
            this.pnlVendre.Name = "pnlVendre";
            this.pnlVendre.Size = new System.Drawing.Size(548, 293);
            this.pnlVendre.TabIndex = 5;
            // 
            // lblValeurActuelle
            // 
            this.lblValeurActuelle.AutoSize = true;
            this.lblValeurActuelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeurActuelle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblValeurActuelle.Location = new System.Drawing.Point(311, 21);
            this.lblValeurActuelle.Name = "lblValeurActuelle";
            this.lblValeurActuelle.Size = new System.Drawing.Size(208, 22);
            this.lblValeurActuelle.TabIndex = 6;
            this.lblValeurActuelle.Text = "VALEUR ACTUELLE :";
            // 
            // lblQuantiteVente
            // 
            this.lblQuantiteVente.AutoSize = true;
            this.lblQuantiteVente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantiteVente.Location = new System.Drawing.Point(19, 131);
            this.lblQuantiteVente.Name = "lblQuantiteVente";
            this.lblQuantiteVente.Size = new System.Drawing.Size(147, 21);
            this.lblQuantiteVente.TabIndex = 5;
            this.lblQuantiteVente.Text = "Quantité à vendre";
            // 
            // lblNombrePossede
            // 
            this.lblNombrePossede.AutoSize = true;
            this.lblNombrePossede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePossede.Location = new System.Drawing.Point(19, 92);
            this.lblNombrePossede.Name = "lblNombrePossede";
            this.lblNombrePossede.Size = new System.Drawing.Size(224, 21);
            this.lblNombrePossede.TabIndex = 4;
            this.lblNombrePossede.Text = "Nombre de titres possédés : ";
            // 
            // btnVendreAction
            // 
            this.btnVendreAction.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVendreAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendreAction.Location = new System.Drawing.Point(19, 195);
            this.btnVendreAction.Name = "btnVendreAction";
            this.btnVendreAction.Size = new System.Drawing.Size(592, 68);
            this.btnVendreAction.TabIndex = 3;
            this.btnVendreAction.Text = "Vendre";
            this.btnVendreAction.UseVisualStyleBackColor = false;
            this.btnVendreAction.Click += new System.EventHandler(this.btnVendreAction_Click);
            // 
            // lblSociete
            // 
            this.lblSociete.AutoSize = true;
            this.lblSociete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociete.Location = new System.Drawing.Point(19, 54);
            this.lblSociete.Name = "lblSociete";
            this.lblSociete.Size = new System.Drawing.Size(74, 21);
            this.lblSociete.TabIndex = 2;
            this.lblSociete.Text = "Société :";
            // 
            // lblVendreTitre
            // 
            this.lblVendreTitre.AutoSize = true;
            this.lblVendreTitre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendreTitre.Location = new System.Drawing.Point(14, 14);
            this.lblVendreTitre.Name = "lblVendreTitre";
            this.lblVendreTitre.Size = new System.Drawing.Size(190, 28);
            this.lblVendreTitre.TabIndex = 1;
            this.lblVendreTitre.Text = "Vendre des actions";
            // 
            // nupQuantite
            // 
            this.nupQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantite.Location = new System.Drawing.Point(19, 159);
            this.nupQuantite.Name = "nupQuantite";
            this.nupQuantite.Size = new System.Drawing.Size(592, 26);
            this.nupQuantite.TabIndex = 0;
            // 
            // pnlAchat
            // 
            this.pnlAchat.Controls.Add(this.btnAchat);
            this.pnlAchat.Controls.Add(this.nupQuantiteAchat);
            this.pnlAchat.Controls.Add(this.lblQuantiteAchat);
            this.pnlAchat.Controls.Add(this.lblValeur);
            this.pnlAchat.Controls.Add(this.lblSociete2);
            this.pnlAchat.Controls.Add(this.lblAchatAction);
            this.pnlAchat.Location = new System.Drawing.Point(578, 501);
            this.pnlAchat.Name = "pnlAchat";
            this.pnlAchat.Size = new System.Drawing.Size(1029, 293);
            this.pnlAchat.TabIndex = 6;
            // 
            // btnAchat
            // 
            this.btnAchat.BackColor = System.Drawing.Color.Khaki;
            this.btnAchat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchat.Location = new System.Drawing.Point(27, 195);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(882, 68);
            this.btnAchat.TabIndex = 7;
            this.btnAchat.Text = "Achat";
            this.btnAchat.UseVisualStyleBackColor = false;
            this.btnAchat.Click += new System.EventHandler(this.btnAchat_Click);
            // 
            // nupQuantiteAchat
            // 
            this.nupQuantiteAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantiteAchat.Location = new System.Drawing.Point(27, 159);
            this.nupQuantiteAchat.Name = "nupQuantiteAchat";
            this.nupQuantiteAchat.Size = new System.Drawing.Size(882, 26);
            this.nupQuantiteAchat.TabIndex = 7;
            // 
            // lblQuantiteAchat
            // 
            this.lblQuantiteAchat.AutoSize = true;
            this.lblQuantiteAchat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantiteAchat.Location = new System.Drawing.Point(23, 131);
            this.lblQuantiteAchat.Name = "lblQuantiteAchat";
            this.lblQuantiteAchat.Size = new System.Drawing.Size(151, 21);
            this.lblQuantiteAchat.TabIndex = 7;
            this.lblQuantiteAchat.Text = "Quantité à acheter";
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.Location = new System.Drawing.Point(23, 92);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(127, 21);
            this.lblValeur.TabIndex = 7;
            this.lblValeur.Text = "Valeur du titre :";
            // 
            // lblSociete2
            // 
            this.lblSociete2.AutoSize = true;
            this.lblSociete2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSociete2.Location = new System.Drawing.Point(23, 54);
            this.lblSociete2.Name = "lblSociete2";
            this.lblSociete2.Size = new System.Drawing.Size(74, 21);
            this.lblSociete2.TabIndex = 7;
            this.lblSociete2.Text = "Société :";
            // 
            // lblAchatAction
            // 
            this.lblAchatAction.AutoSize = true;
            this.lblAchatAction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchatAction.Location = new System.Drawing.Point(22, 14);
            this.lblAchatAction.Name = "lblAchatAction";
            this.lblAchatAction.Size = new System.Drawing.Size(179, 28);
            this.lblAchatAction.TabIndex = 7;
            this.lblAchatAction.Text = "Achat des actions";
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 806);
            this.Controls.Add(this.pnlAchat);
            this.Controls.Add(this.pnlVendre);
            this.Controls.Add(this.lblMyBudget);
            this.Controls.Add(this.lblCotationsDuJour);
            this.Controls.Add(this.lblMonPortefeuille);
            this.Controls.Add(this.dtgCotations);
            this.Controls.Add(this.dtgMonPortefeuille);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Operations";
            this.Text = "Operations";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonPortefeuille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).EndInit();
            this.pnlVendre.ResumeLayout(false);
            this.pnlVendre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantite)).EndInit();
            this.pnlAchat.ResumeLayout(false);
            this.pnlAchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantiteAchat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMonPortefeuille;
        private System.Windows.Forms.DataGridView dtgCotations;
        private System.Windows.Forms.Label lblMonPortefeuille;
        private System.Windows.Forms.Label lblCotationsDuJour;
        private System.Windows.Forms.Label lblMyBudget;
        private System.Windows.Forms.Panel pnlVendre;
        private System.Windows.Forms.Label lblSociete;
        private System.Windows.Forms.Label lblVendreTitre;
        private System.Windows.Forms.NumericUpDown nupQuantite;
        private System.Windows.Forms.Label lblQuantiteVente;
        private System.Windows.Forms.Label lblNombrePossede;
        private System.Windows.Forms.Button btnVendreAction;
        private System.Windows.Forms.Label lblValeurActuelle;
        private System.Windows.Forms.Panel pnlAchat;
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.NumericUpDown nupQuantiteAchat;
        private System.Windows.Forms.Label lblQuantiteAchat;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Label lblSociete2;
        private System.Windows.Forms.Label lblAchatAction;
    }
}