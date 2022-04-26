
namespace LLWS.UserInterface.Responsable
{
    partial class ManageCotations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMajCotations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGestionCotations = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMajCotations);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSendText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblGestionCotations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 574);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mise à jour des cotations";
            // 
            // btnMajCotations
            // 
            this.btnMajCotations.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMajCotations.Enabled = false;
            this.btnMajCotations.Location = new System.Drawing.Point(87, 314);
            this.btnMajCotations.Name = "btnMajCotations";
            this.btnMajCotations.Size = new System.Drawing.Size(202, 54);
            this.btnMajCotations.TabIndex = 4;
            this.btnMajCotations.Text = "Mettre à jour";
            this.btnMajCotations.UseVisualStyleBackColor = false;
            this.btnMajCotations.Click += new System.EventHandler(this.btnMajCotations_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom_fichier.txt";
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(87, 185);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(202, 45);
            this.btnSendText.TabIndex = 2;
            this.btnSendText.Text = "Envoyer";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Télécharger un fichier texte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGestionCotations
            // 
            this.lblGestionCotations.AutoSize = true;
            this.lblGestionCotations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCotations.Location = new System.Drawing.Point(90, 30);
            this.lblGestionCotations.Name = "lblGestionCotations";
            this.lblGestionCotations.Size = new System.Drawing.Size(216, 28);
            this.lblGestionCotations.TabIndex = 0;
            this.lblGestionCotations.Text = "Gestion des cotations";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(396, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(625, 515);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ManageCotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 574);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCotations";
            this.Text = "ManageCotations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGestionCotations;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnMajCotations;
        private System.Windows.Forms.Label label1;
    }
}