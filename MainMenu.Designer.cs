
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
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.panelWindowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.pnlSidebar.Controls.Add(this.btnDocuments);
            this.pnlSidebar.Controls.Add(this.btnOperations);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnRegister);
            this.pnlSidebar.Controls.Add(this.btnLogin);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(176, 553);
            this.pnlSidebar.TabIndex = 0;
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
            this.btnDocuments.Location = new System.Drawing.Point(0, 275);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDocuments.Size = new System.Drawing.Size(176, 52);
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
            this.btnOperations.Location = new System.Drawing.Point(0, 223);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOperations.Size = new System.Drawing.Size(176, 52);
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
            this.btnProducts.Location = new System.Drawing.Point(0, 171);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(176, 52);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "   Produits";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Image = global::LLWS.Properties.Resources.voting;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 119);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegister.Size = new System.Drawing.Size(176, 52);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "   Inscription";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Image = global::LLWS.Properties.Resources.user;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 67);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(176, 52);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "   Connexion";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 67);
            this.panelLogo.TabIndex = 0;
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.panelWindowTitle.Controls.Add(this.labelWindowTitle);
            this.panelWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowTitle.Location = new System.Drawing.Point(176, 0);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(906, 67);
            this.panelWindowTitle.TabIndex = 1;
            this.panelWindowTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWindowTitle_Paint);
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowTitle.ForeColor = System.Drawing.Color.White;
            this.labelWindowTitle.Location = new System.Drawing.Point(407, 20);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(120, 30);
            this.labelWindowTitle.TabIndex = 0;
            this.labelWindowTitle.Text = "Connexion";
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(176, 67);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(906, 486);
            this.panelMainWindow.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panelMainWindow);
            this.Controls.Add(this.panelWindowTitle);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.pnlSidebar.ResumeLayout(false);
            this.panelWindowTitle.ResumeLayout(false);
            this.panelWindowTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnOperations;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelWindowTitle;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Panel panelMainWindow;
    }
}

