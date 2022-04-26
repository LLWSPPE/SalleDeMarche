
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblMenuAdmin = new System.Windows.Forms.Label();
            this.btnManageCotations = new System.Windows.Forms.Button();
            this.btnMesMouvements = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserBudget = new System.Windows.Forms.Label();
            this.lblMyBudget = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWindowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.pnlSidebar.Controls.Add(this.lblMenuAdmin);
            this.pnlSidebar.Controls.Add(this.btnManageCotations);
            this.pnlSidebar.Controls.Add(this.btnMesMouvements);
            this.pnlSidebar.Controls.Add(this.btnManageUser);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnOperations);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(263, 1035);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblMenuAdmin
            // 
            this.lblMenuAdmin.AutoSize = true;
            this.lblMenuAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMenuAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMenuAdmin.Location = new System.Drawing.Point(0, 680);
            this.lblMenuAdmin.Name = "lblMenuAdmin";
            this.lblMenuAdmin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblMenuAdmin.Size = new System.Drawing.Size(232, 28);
            this.lblMenuAdmin.TabIndex = 11;
            this.lblMenuAdmin.Text = "Menu administrateur";
            // 
            // btnManageCotations
            // 
            this.btnManageCotations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnManageCotations.FlatAppearance.BorderSize = 0;
            this.btnManageCotations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCotations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCotations.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageCotations.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCotations.Image")));
            this.btnManageCotations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCotations.Location = new System.Drawing.Point(0, 708);
            this.btnManageCotations.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCotations.Name = "btnManageCotations";
            this.btnManageCotations.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnManageCotations.Size = new System.Drawing.Size(263, 89);
            this.btnManageCotations.TabIndex = 10;
            this.btnManageCotations.Text = "   Gestion cotations";
            this.btnManageCotations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageCotations.UseVisualStyleBackColor = true;
            this.btnManageCotations.Click += new System.EventHandler(this.btnManageCotations_Click);
            // 
            // btnMesMouvements
            // 
            this.btnMesMouvements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesMouvements.FlatAppearance.BorderSize = 0;
            this.btnMesMouvements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesMouvements.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesMouvements.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMesMouvements.Image = ((System.Drawing.Image)(resources.GetObject("btnMesMouvements.Image")));
            this.btnMesMouvements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesMouvements.Location = new System.Drawing.Point(0, 235);
            this.btnMesMouvements.Margin = new System.Windows.Forms.Padding(4);
            this.btnMesMouvements.Name = "btnMesMouvements";
            this.btnMesMouvements.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnMesMouvements.Size = new System.Drawing.Size(263, 64);
            this.btnMesMouvements.TabIndex = 8;
            this.btnMesMouvements.Text = "   Mes mouvements";
            this.btnMesMouvements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesMouvements.UseVisualStyleBackColor = true;
            this.btnMesMouvements.Click += new System.EventHandler(this.btnMesMouvements_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(0, 797);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnManageUser.Size = new System.Drawing.Size(263, 89);
            this.btnManageUser.TabIndex = 7;
            this.btnManageUser.Text = "   Gestion utilisateurs";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserBudget);
            this.panel1.Controls.Add(this.lblMyBudget);
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 886);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 149);
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
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDeconnexion.Size = new System.Drawing.Size(263, 64);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "   Déconnexion";
            this.btnDeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
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
            this.btnOperations.Location = new System.Drawing.Point(0, 171);
            this.btnOperations.Margin = new System.Windows.Forms.Padding(4);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnOperations.Size = new System.Drawing.Size(263, 64);
            this.btnOperations.TabIndex = 4;
            this.btnOperations.Text = "   Acheter / Vendre";
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
            this.btnProducts.Location = new System.Drawing.Point(0, 107);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(263, 64);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "   Cotations du jour";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(263, 107);
            this.panelLogo.TabIndex = 0;
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.panelWindowTitle.Controls.Add(this.labelWindowTitle);
            this.panelWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowTitle.Location = new System.Drawing.Point(263, 0);
            this.panelWindowTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(1661, 82);
            this.panelWindowTitle.TabIndex = 1;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowTitle.ForeColor = System.Drawing.Color.White;
            this.labelWindowTitle.Location = new System.Drawing.Point(769, 25);
            this.labelWindowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(0, 37);
            this.labelWindowTitle.TabIndex = 0;
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(263, 82);
            this.panelMainWindow.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(1661, 953);
            this.panelMainWindow.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.panelMainWindow);
            this.Controls.Add(this.panelWindowTitle);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "LLWS Network";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWindowTitle.ResumeLayout(false);
            this.panelWindowTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOperations;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelWindowTitle;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Panel panelMainWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserBudget;
        private System.Windows.Forms.Label lblMyBudget;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnMesMouvements;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageCotations;
        private System.Windows.Forms.Label lblMenuAdmin;
    }
}

