﻿
namespace LLWS
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserBudget = new System.Windows.Forms.Label();
            this.lblMyBudget = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageCotations = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWindowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.pnlSidebar.Controls.Add(this.btnManageCotations);
            this.pnlSidebar.Controls.Add(this.btnManageUser);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnDocuments);
            this.pnlSidebar.Controls.Add(this.btnOperations);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(235, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserBudget);
            this.panel1.Controls.Add(this.lblMyBudget);
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 149);
            this.panel1.TabIndex = 6;
            // 
            // lblUserBudget
            // 
            this.lblUserBudget.AutoSize = true;
            this.lblUserBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserBudget.Location = new System.Drawing.Point(8, 47);
            this.lblUserBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserBudget.Name = "lblUserBudget";
            this.lblUserBudget.Size = new System.Drawing.Size(59, 23);
            this.lblUserBudget.TabIndex = 8;
            this.lblUserBudget.Text = "label1";
            // 
            // lblMyBudget
            // 
            this.lblMyBudget.AutoSize = true;
            this.lblMyBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMyBudget.Location = new System.Drawing.Point(4, 11);
            this.lblMyBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyBudget.Name = "lblMyBudget";
            this.lblMyBudget.Size = new System.Drawing.Size(105, 23);
            this.lblMyBudget.TabIndex = 7;
            this.lblMyBudget.Text = "Mon budget";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Maroon;
            this.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeconnexion.Image = global::LLWS.Properties.Resources.writing;
            this.btnDeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 85);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDeconnexion.Size = new System.Drawing.Size(235, 64);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "   Déconnexion";
            this.btnDeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocuments.FlatAppearance.BorderSize = 0;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocuments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocuments.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDocuments.Image = global::LLWS.Properties.Resources.writing;
            this.btnDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocuments.Location = new System.Drawing.Point(0, 210);
            this.btnDocuments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDocuments.Size = new System.Drawing.Size(235, 64);
            this.btnDocuments.TabIndex = 5;
            this.btnDocuments.Text = "   Documents";
            this.btnDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnOperations
            // 
            this.btnOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperations.FlatAppearance.BorderSize = 0;
            this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOperations.Image = global::LLWS.Properties.Resources.chart;
            this.btnOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperations.Location = new System.Drawing.Point(0, 146);
            this.btnOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnOperations.Size = new System.Drawing.Size(235, 64);
            this.btnOperations.TabIndex = 4;
            this.btnOperations.Text = "   Opérations";
            this.btnOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperations.UseVisualStyleBackColor = true;
            this.btnOperations.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProducts.Image = global::LLWS.Properties.Resources.cubes;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 82);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(235, 64);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "   Produits";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(235, 82);
            this.panelLogo.TabIndex = 0;
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.panelWindowTitle.Controls.Add(this.labelWindowTitle);
            this.panelWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowTitle.Location = new System.Drawing.Point(235, 0);
            this.panelWindowTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(1208, 82);
            this.panelWindowTitle.TabIndex = 1;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowTitle.ForeColor = System.Drawing.Color.White;
            this.labelWindowTitle.Location = new System.Drawing.Point(543, 25);
            this.labelWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(154, 37);
            this.labelWindowTitle.TabIndex = 0;
            this.labelWindowTitle.Text = "Connexion";
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(235, 82);
            this.panelMainWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(1208, 599);
            this.panelMainWindow.TabIndex = 2;
            // 
            // btnManageUser
            // 
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageUser.Image = global::LLWS.Properties.Resources.writing;
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(0, 274);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnManageUser.Size = new System.Drawing.Size(235, 64);
            this.btnManageUser.TabIndex = 7;
            this.btnManageUser.Text = "   Gestion utilisateurs";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageCotations
            // 
            this.btnManageCotations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCotations.FlatAppearance.BorderSize = 0;
            this.btnManageCotations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCotations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCotations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageCotations.Image = global::LLWS.Properties.Resources.writing;
            this.btnManageCotations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCotations.Location = new System.Drawing.Point(0, 338);
            this.btnManageCotations.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCotations.Name = "btnManageCotations";
            this.btnManageCotations.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnManageCotations.Size = new System.Drawing.Size(235, 64);
            this.btnManageCotations.TabIndex = 8;
            this.btnManageCotations.Text = "   Gestion cotations";
            this.btnManageCotations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageCotations.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 681);
            this.Controls.Add(this.panelMainWindow);
            this.Controls.Add(this.panelWindowTitle);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWindowTitle.ResumeLayout(false);
            this.panelWindowTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnOperations;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelWindowTitle;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Panel panelMainWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserBudget;
        private System.Windows.Forms.Label lblMyBudget;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnManageCotations;
        private System.Windows.Forms.Button btnManageUser;
    }
}

