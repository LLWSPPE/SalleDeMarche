﻿
namespace LLWS.UserInterface.Products
{
    partial class Products
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
            this.dtgCotations = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCotations
            // 
            this.dtgCotations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCotations.Location = new System.Drawing.Point(12, 64);
            this.dtgCotations.Name = "dtgCotations";
            this.dtgCotations.RowHeadersWidth = 51;
            this.dtgCotations.RowTemplate.Height = 24;
            this.dtgCotations.Size = new System.Drawing.Size(979, 413);
            this.dtgCotations.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(394, 13);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(273, 44);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Cotations du jour";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 521);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgCotations);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCotations;
        private System.Windows.Forms.Label lblProduct;
    }
}