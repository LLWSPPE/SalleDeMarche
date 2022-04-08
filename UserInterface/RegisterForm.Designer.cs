
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription page";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFirstName.Location = new System.Drawing.Point(194, 154);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(210, 20);
            this.txbFirstName.TabIndex = 1;
            this.txbFirstName.Text = "Nom";
            this.txbFirstName.TextChanged += new System.EventHandler(this.txbFirstName_TextChanged);
            this.txbFirstName.Enter += new System.EventHandler(this.txbFirstName_Enter);
            this.txbFirstName.Leave += new System.EventHandler(this.txbFirstName_Leave);
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastName.Location = new System.Drawing.Point(419, 154);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(210, 20);
            this.txbLastName.TabIndex = 2;
            this.txbLastName.Text = "Prénom";
            this.txbLastName.Enter += new System.EventHandler(this.txbLastName_Enter);
            this.txbLastName.Leave += new System.EventHandler(this.txbLastName_Leave);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(194, 201);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(436, 20);
            this.txbEmail.TabIndex = 3;
            this.txbEmail.Text = "Email";
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Location = new System.Drawing.Point(193, 241);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(436, 20);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Text = "Mot de passe";
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbConfirmPassword.Location = new System.Drawing.Point(194, 280);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(436, 20);
            this.txbConfirmPassword.TabIndex = 5;
            this.txbConfirmPassword.Text = "Confirmez le mot de passe";
            this.txbConfirmPassword.Enter += new System.EventHandler(this.txbConfirmPassword_Enter);
            this.txbConfirmPassword.Leave += new System.EventHandler(this.txbConfirmPassword_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Location = new System.Drawing.Point(385, 342);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(56, 19);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "M\'inscrire";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturnToLogin.Location = new System.Drawing.Point(194, 342);
            this.btnReturnToLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(84, 19);
            this.btnReturnToLogin.TabIndex = 13;
            this.btnReturnToLogin.Text = "Retour";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(21, 401);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "lblError";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturnToLogin;
        private System.Windows.Forms.Label lblError;
    }
}