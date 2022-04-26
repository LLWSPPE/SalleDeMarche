
namespace LLWS.UserInterface
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblnscription = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnscription
            // 

            this.lblnscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnscription.AutoSize = true;
            this.lblnscription.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnscription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnscription.Location = new System.Drawing.Point(456, 164);
            this.lblnscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnscription.Name = "lblnscription";
            this.lblnscription.Size = new System.Drawing.Size(157, 38);
            this.lblnscription.TabIndex = 0;
            this.lblnscription.Text = "Inscription";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Location = new System.Drawing.Point(253, 220);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(279, 30);
            this.txbFirstName.TabIndex = 1;
            this.txbFirstName.Text = "Nom";
            this.txbFirstName.TextChanged += new System.EventHandler(this.txbFirstName_TextChanged);
            this.txbFirstName.Enter += new System.EventHandler(this.txbFirstName_Enter);
            this.txbFirstName.Leave += new System.EventHandler(this.txbFirstName_Leave);
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.Location = new System.Drawing.Point(553, 220);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(279, 30);
            this.txbLastName.TabIndex = 2;
            this.txbLastName.Text = "Prénom";
            this.txbLastName.Enter += new System.EventHandler(this.txbLastName_Enter);
            this.txbLastName.Leave += new System.EventHandler(this.txbLastName_Leave);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(253, 277);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(580, 30);
            this.txbEmail.TabIndex = 3;
            this.txbEmail.Text = "Email";
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(251, 327);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(580, 30);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Mot de passe";
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmPassword.Location = new System.Drawing.Point(253, 375);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(580, 30);
            this.txbConfirmPassword.TabIndex = 5;
            this.txbConfirmPassword.Text = "Confirmez le mot de passe";
            this.txbConfirmPassword.Enter += new System.EventHandler(this.txbConfirmPassword_Enter);
            this.txbConfirmPassword.Leave += new System.EventHandler(this.txbConfirmPassword_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(442, 426);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(391, 48);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "M\'inscrire";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnToLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnToLogin.FlatAppearance.BorderSize = 0;
            this.btnReturnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturnToLogin.Location = new System.Drawing.Point(253, 426);
            this.btnReturnToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(159, 48);
            this.btnReturnToLogin.TabIndex = 13;
            this.btnReturnToLogin.Text = "Retour";
            this.btnReturnToLogin.UseVisualStyleBackColor = false;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LLWS.Properties.Resources.sss;
            this.pictureBox1.InitialImage = global::LLWS.Properties.Resources.sss;
            this.pictureBox1.Location = new System.Drawing.Point(356, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 136);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lblnscription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnscription;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturnToLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}