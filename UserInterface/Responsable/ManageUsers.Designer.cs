﻿
namespace LLWS.UserInterface.Responsable
{
    partial class ManageUsers
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
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.lblGestionUtilisateur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dtgUsers
            // 
            this.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(97, 87);
            this.dtgUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.RowHeadersWidth = 51;
            this.dtgUsers.RowTemplate.Height = 24;
            this.dtgUsers.Size = new System.Drawing.Size(983, 536);
            this.dtgUsers.TabIndex = 1;
            this.dtgUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellContentClick);
            // 
            // lblGestionUtilisateur
            // 
            this.lblGestionUtilisateur.AutoSize = true;
            this.lblGestionUtilisateur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUtilisateur.Location = new System.Drawing.Point(410, 43);
            this.lblGestionUtilisateur.Name = "lblGestionUtilisateur";
            this.lblGestionUtilisateur.Size = new System.Drawing.Size(372, 28);
            this.lblGestionUtilisateur.TabIndex = 2;
            this.lblGestionUtilisateur.Text = "Responsable - Gestion des utilisateurs";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 653);
            this.Controls.Add(this.lblGestionUtilisateur);
            this.Controls.Add(this.dtgUsers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageUsers";
            this.Text = "Gestion des utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Label lblGestionUtilisateur;
    }
}